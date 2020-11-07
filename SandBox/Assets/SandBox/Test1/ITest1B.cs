using System;
using System.Collections.Generic;


namespace SandBox.Test1
{
    public interface ITest1B
    {
        void SetData(string data);
        IReadOnlyList<(string name, string url)> GetDataList();
    }
}