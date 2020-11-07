using System;
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
        
        ITest1B testB;
        Test1D.Factory test1DFactory;        
        
        [Inject]
        void Injection(
            ITest1B _testB,
            Test1D.Factory _test1DFactory)
        {
            testB = _testB;
            test1DFactory = _test1DFactory;
        }

        
        // TODO : この辺で新しいクラスを作成する( Factoryを利用して ).
        void Start()
        {
            var st = new StringBuilder();
            var a = testB.GetDataList();
            foreach (var aa in a)
            {
                st.AppendLine($"{aa.name} | {aa.url}");
                Test1D obj = test1DFactory.Create();
                obj.transform.SetParent(transform);
                obj.Initialize(aa.name, aa.url);
            }
            Debug.Log(st.ToString());
        }
    }
}