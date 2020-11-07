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

    