using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{    
    
     private string _name;
    private string job;
    private int hp;
    private int atk;

    public Character(string name,string job,int hp,int atk)
    {
        this._name = name;
        this.job = job;
        this.hp = hp;
        this.atk = atk;
    }
    public string getName()
    {
        return _name;
    }
    public string getJob()
    {
        return job;
    }
    public int getHP()
    {
        return hp;
    }
    public int getAtk()
    {
        return atk;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
