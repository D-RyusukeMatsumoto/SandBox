using UnityEngine;
using Zenject;

namespace SandBox.Test1
{
    public class Test1Installer : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ITest1B>()
                .To<Test1B>()
                .FromComponentInHierarchy()
                .AsCached()
                .NonLazy();


            Container.BindFactory<Test1C, Test1C.Factory>()
                .FromComponentInNewPrefabResource("Test1C")
                .AsCached();
        }
    }
}

    