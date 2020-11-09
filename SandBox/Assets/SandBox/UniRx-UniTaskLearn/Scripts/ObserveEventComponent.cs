using System;
using UnityEngine;

namespace UniRx_UniTaskLearn.Section2.MyObserver
{
    class ObserveEventComponent : MonoBehaviour
    {
        [SerializeField] private CountDownEventProvider countDownEventProvider;

        private PrintLogObserver<string> printLogObserver;
        private IDisposable disposable;

        
        private void Start()
        {
            // PrintLogObserver インスタンスを作成.
            printLogObserver = new PrintLogObserver<string>();    
            
            // Subject の Subscribeを呼び出して、 observer を登録する.
            disposable = countDownEventProvider
                .CountDownObservable
                .Subscribe(printLogObserver);
        }


        private void OnDestroy()
        {
            disposable?.Dispose();
        }
    }
}