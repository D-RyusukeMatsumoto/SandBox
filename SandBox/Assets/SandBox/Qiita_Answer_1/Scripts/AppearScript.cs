using UnityEngine;

namespace Qiita_Answer_1
{
    public class AppearScript : MonoBehaviour 
    {

        //　出現させる敵を入れておく
        [SerializeField] GameObject[] enemys;

        //　次に敵が出現するまでの時間
        [SerializeField] float appearNextTime;
    
        //　この場所から出現する敵の数
        [SerializeField] int maxNumOfEnemys;
    
        //　今何人の敵を出現させたか（総数）
        private int numberOfEnemys;
    
        //　待ち時間計測フィールド
        private float elapsedTime;

        // enemys array index.
        // I use the SerializeField attribute for confirmation in Inspector.
        // It should not be edited on Inspector.
        [SerializeField] private int index;
    
        private void Start() 
        {
            numberOfEnemys = 0;
            elapsedTime = 0f;
        }

    
        private void Update()
        {
        
            //　この場所から出現する最大数を超えてたら何もしない
            if (numberOfEnemys >= maxNumOfEnemys) {
                return; 
            }

            //　経過時間を足す
            elapsedTime += Time.deltaTime;

            //　経過時間が経ったら
            if (elapsedTime > appearNextTime) {
                elapsedTime = 0f;

                AppearEnemy ();
            }
        }

        private void AppearEnemy() 
        {

            // Generate an enemy for a given index.
            var position = new Vector3(index, index, index);
            Instantiate(enemys[index], position, Quaternion.Euler (0f, 0f, 0f));

            // Calculate the next index.
            int nextIndex = (int)Mathf.Repeat(index + 1, enemys.Length);
            index = nextIndex;

            numberOfEnemys++;
            elapsedTime = 0f;
        }

    }    
}

