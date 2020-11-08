using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Zenject;

namespace SandBox.Test1
{
    /// <summary>
    /// ランタイムに生成されるオブジェクト生成クラス.
    /// </summary>
    public class Test1C : MonoBehaviour
    {
        
        public class Factory : PlaceholderFactory<Test1C> { }

        [SerializeField] List<Test1D> test1Ds;
        ITest1B testB;
        
        [Inject]
        void Injection(
            ITest1B _testB)
        {
            testB = _testB;
        }

        
        // TODO : この辺で新しいクラスを作成する( Factoryを利用して ).
        void Start()
        {
            var st = new StringBuilder();
            var a = testB.GetDataList();
            for (var i = 0; i < a.Count; ++i)
            {
                st.AppendLine($"{a[i].name} | {a[i].url}");
                test1Ds[i].SetData(a[i].name, a[i].url);
            }
            Debug.Log(st.ToString());
        }
    }
}