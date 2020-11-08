using System;
using UnityEngine;
using Zenject;

namespace SandBox.Test1
{
    /// <summary>
    /// Test1Bからファクトリを介して生成されるオブジェクト.
    /// </summary>
    public class Test1D : MonoBehaviour
    {
        string url;
        ITest1B test1B;

        [Inject]
        void Injection(
            ITest1B _test1B)
        {
            test1B = _test1B;
        }


        void Hoge()
        {
            test1B.SetData(url);
        }


        public void SetData(
            string _name,
            string _url)
        {
            gameObject.SetActive(true);
            gameObject.name = _name;
            url = _url;
        }
    }
}