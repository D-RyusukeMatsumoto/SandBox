using System;

namespace UniRx_UniTaskLearn.Section2.MyObserver
{
    
    public class PrintLogObserver<T> : IObserver<T>
    {
        public void OnCompleted()
        {
            UnityEngine.Debug.Log("OnCompleted!");
        }

        public void OnError(Exception error)
        {
            UnityEngine.Debug.LogError(error);
        }

        public void OnNext(T value)
        {
            UnityEngine.Debug.Log(value);
        }
    }
}

    