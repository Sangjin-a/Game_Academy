using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    private Transform tr;
    int step;
    // Start is called before the first frame update
    private void Awake()
    {
        player = this.gameObject;
        tr = player.transform;
        
    }
    void Start()
    {

        StartCoroutine("fire");
    }

    // Update is called once per frame
    void Update()
    {
      

        if (step == 1)
        {
            if (player.transform.position.x <= -2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position -= new Vector3(3 * Time.deltaTime, 0, 0);
            }

        }

        if (step == 2)
        {
            if (player.transform.position.x >= 2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
            }
        }

        if (step == 3)
        {
            if (player.transform.position.y >= 4f)
            {
                step = 0;
            }
            else
            {
                player.transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
            }
        }
        if (step == 4)
        {
            if (player.transform.position.y <= -2f)
            {
                step = 0;
            }
            else
            {
                player.transform.position += new Vector3(0, -3 * Time.deltaTime, 0);
            }
        }
        Debug.Log(tr);       
      
    }
    IEnumerator fire()
    {
        while (true)
        { 
            Debug.Log("fire");
            Instantiate(bullet, tr.position, tr.rotation);
            yield return new WaitForSeconds(1f);
        }
    }
    public void leftMove()
    {
        step = 1;
    }
    public void rightMove()
    {
        step = 2;
    }
    public void upMove()
    {
        step = 3;
    }
    public void downMove()
    {
        step = 4;
    }
}
