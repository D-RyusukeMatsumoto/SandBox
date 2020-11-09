using System;
using System.Collections;
using UnityEngine;
using UniRx;

namespace UniRx_UniTaskLearn.Section2.MyObserver
{
    /// <summary>
    /// 指定秒数カウントしてイベント通知する.
    /// </summary>
    public class CountDownEventProvider : MonoBehaviour
    {
        // カウントする秒数.
        [SerializeField] int countSeconds = 10;
        
        // Subjectのインスタンス.
        Subject<string> subject;
        
        // Subject の IObservable インターフェース部分のみ公開する.
        public IObservable<string> CountDownObservable => subject;


        void Awake()
        {
            subject = new Subject<string>();
            
            // カウントダウンコルーチン起動.
            StartCoroutine(CountCoroutine());
        }


        private void OnDestroy()
        {
            // GameObject が削除されたときに subject を解放する.
            subject.Dispose();
        }
        

        private IEnumerator CountCoroutine()
        {
            int current = countSeconds;
            string text = "ABCDEFG";

            while (0 < text.Length)
            {
                // 現在の値を発行する.
                subject.OnNext(text);
                text = text.Remove(0, 1);
                yield return new WaitForSeconds(1f);
            }
            
            // 最後に 0 と OnCompleted を発行する.
            subject.OnNext("HogeHogeHogw");
            subject.OnCompleted();
        }
    }
}