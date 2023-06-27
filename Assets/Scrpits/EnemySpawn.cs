using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;



    private void Start()
    {
            for(int i = 0; i < 10; i++) { 
                GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
                obj.transform.position = new Vector3(Random.Range(-2,2), 5+Random.Range(0,3), 0);
                Enemy e = new Enemy(Enemy.EnemeyType.Basic, 100, 10, i+0.5f);

                obj.GetComponent<EnemyObject>().SetEnmey(e);
        }
    }
    void Update()
    {
        


    }
}
