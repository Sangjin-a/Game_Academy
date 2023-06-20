using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leftMove() {
        tr.position +=new Vector3(-10 * Time.deltaTime, 0, 0);
    }
    public void rightMove() {
        tr.position += new Vector3(+10 * Time.deltaTime, 0, 0);
    }
}
