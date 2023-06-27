using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{


    [SerializeField] private Sprite[] enemyImage;
    [SerializeField] private Slider hpBar;

    Enemy enemy;
    public void SetEnmey(Enemy e)
    {
        this.enemy = e;
        hpBar.maxValue = enemy.getHp;
        hpBar.value = enemy.getHp;
    }

    private void MoveDown()
    {
        if (gameObject.transform.position.y > -2)
            gameObject.transform.position += new Vector3(0, -enemy.getSpeed*Time.deltaTime, 0);
    }
    void Start()
    {
        //SetEnmey(new Enemy(Enemy.EnemeyType.Basic, 100, 10, 1.5f));
        Debug.Log("Speed: " + enemy.getSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
            return;

            MoveDown();
        
    }
    
}
