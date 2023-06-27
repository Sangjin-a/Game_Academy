using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x+" "+transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
        Destroy();
    }
    private void Destroy()
    {
        if (gameObject.transform.position.y >= 4)
        {
            Destroy(gameObject);
        }
    }
}
