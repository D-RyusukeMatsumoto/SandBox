using UnityEngine;
using Zenject;


namespace SandBox.Test1
{
    /// <summary>
    /// Test1Bをランタイムに生成するTest1Aクラス.
    /// </summary>
    public class Test1A : MonoBehaviour
    {
        [SerializeField] bool useTest1B = true;
        [SerializeField] Test1B test1B;
        [SerializeField] Test1BB test1BB;

        void Start()
        {
            if (useTest1B)
            {
                test1B.enabled = true;
            }
            else
            {
                test1BB.enabled = true;
            }
        }

    }
}