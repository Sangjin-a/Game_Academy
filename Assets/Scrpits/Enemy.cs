using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{

    public enum EnemeyType{
        Basic=0,
        Range
    }
    EnemeyType enemeyType;
    
    private int hp;
    private int atk;
    private float speed;
    public Enemy(EnemeyType type,int hp,int atk,float speed)
    {
        this.enemeyType = type;
        this.hp = hp;
        this.atk = atk;
        this.speed = speed;
        
    }
    public int getHp
    {
        get { return this.hp; }
    }
    public int getAtk
    {
        get { return this.atk; }
    }
    public float getSpeed
    {
        get { return this.speed; }
    }

    public bool Hit(int damage)
    {
        this.hp -= damage;
        if (this.hp < 0)
            return false;
        else
            return true;
    }
}
