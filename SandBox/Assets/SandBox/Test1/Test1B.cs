using System;
using System.Collections;
using System.Collections.Generic;
using SandBox.Test1;
using Zenject;
using UnityEngine;


namespace SandBox.Test1
{
    /// <summary>
    /// フラグとかでランタイムに生成される想定の Test1B.
    /// </summary>
    public class Test1B : MonoBehaviour, ITest1B
    {


        public class SameData
        {
            public string url;
            public string name;
            public string hoge;
            public string fuga;
        }


        Test1C.Factory test1CFactory;
        

        [Inject]
        void Injection(
            Test1C.Factory _test1CFactory)
        {
            test1CFactory = _test1CFactory;
        }


        void Start()
        {
            test1CFactory.Create();
        }

        void Update()
        {
        }


        public void SetData(string data)
        {
            
        }


        public IReadOnlyList<(string, string)> GetDataList()
        {
            List<(string, string)> retList = new List<(string name, string url)>();
            retList.Add(("nameA", "UrlA"));
            retList.Add(("nameB", "UrlB"));
            return retList;
        }
    }

}

    