using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{


    [SerializeField] private Sprite[] enemyImage;

    Enemy enemy;
    public void SetEnmey(Enemy e)
    {
        this.enemy = e;
    }

    private void MoveDown()
    {
        gameObject.transform.position += new Vector3(0, -1*Time.deltaTime, 0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y>-2)
            MoveDown();
        
    }
}
