using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    List<EnemyObject> enemy_OBJ_List = new List<EnemyObject>();


    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
          
        }
    }
    void Update()
    {

        CreateEnemy();

    }

    private void CreateEnemy()
    {
        if (enemy_OBJ_List.Count < 10)
        {
            GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
            obj.transform.position = new Vector3(Random.Range(-3, 3), 5 + Random.Range(10, 15), 0);
            Enemy e = new Enemy(Enemy.EnemeyType.Basic, Random.Range(5,15), 10,Random.Range(1,4));

            EnemyObject enemyObject = obj.GetComponent<EnemyObject>();
            enemyObject.SetEnmey(e);
            enemy_OBJ_List.Add(enemyObject);
            Debug.Log(enemy_OBJ_List.Count);

        }
    }
}
