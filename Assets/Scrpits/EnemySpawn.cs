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
            GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
            obj.transform.position = new Vector3(Random.Range(-2, 2), 5 + Random.Range(0, 3), 0);
            Enemy e = new Enemy(Enemy.EnemeyType.Basic, 100, 10, i + 0.5f);

            EnemyObject enemyObject = obj.GetComponent<EnemyObject>();
            enemyObject.SetEnmey(e);
            enemy_OBJ_List.Add(enemyObject);
            Debug.Log(enemy_OBJ_List.Count);
        }
    }
    void Update()
    {



    }
}
