using UnityEngine;
using Zenject;


namespace SandBox.Test1
{
    /// <summary>
    /// Test1Bをランタイムに生成するTest1Aクラス.
    /// </summary>
    public class Test1A : MonoBehaviour
    {
        DiContainer container;

        [Inject]
        void Injection(
            DiContainer _container)
        {
            container = _container;
        }


        void Start()
        {
            // TODO : 一旦クラスが同じオブジェクトに配置されてるバージョンで作成してみる.
            //container.InstantiateComponent<Test1B>(gameObject);
            //test1CFactory.Create();
        }

    }
}