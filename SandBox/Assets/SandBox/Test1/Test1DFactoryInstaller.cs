using SandBox.Test1;
using UnityEngine;
using Zenject;

namespace SandBox.Test1
{
    public class Test1DFactoryInstaller : MonoInstaller
    {
        public override void Start()
        {

        }


        [SerializeField] GameObject prefab;
        public override void InstallBindings()
        {
            Container.BindFactory<Test1D, Test1D.Factory>()
                .FromComponentInNewPrefab(prefab)
                .AsTransient();
        }
    }
}

    