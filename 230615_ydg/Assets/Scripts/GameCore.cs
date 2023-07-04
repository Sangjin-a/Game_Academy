using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{

    private static GameCore instance;

    public static GameCore Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject item;
    [SerializeField] private GameObject bulletSpawn;
    [SerializeField] private GameObject bullet;

    Player playerInfo;

    float delay = 0f;
    float attackSpeed = 1f;
    private bool isFeverTime = false;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        playerInfo = new Player(5, 10);
        StartCoroutine(InitItem());
    }


    public void EarnItem()
    {
        if (isFeverTime) return;
        isFeverTime = true;
        StartCoroutine(FeverTimeUpdate());
    }


    private void StopFeverTime()
    {
        if (!isFeverTime) return;
        isFeverTime = false;
        attackSpeed = 1f;
        StopCoroutine(FeverTimeUpdate());
    }

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;

        if (isFeverTime)
        {
            Debug.Log("Fever Time");
        }
        else
        {
            Debug.Log("NONE");
        }


        if (delay >= attackSpeed)
        {
            delay = 0f;

            GameObject obj = Instantiate(bullet, Vector3.zero, Quaternion.identity, bulletSpawn.transform);
            obj.transform.position = player.transform.position;
            int dmg = playerInfo.Atk;
            obj.GetComponent<Bullet>().InitBullet(dmg);

            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3f);
        }
      
    }


    IEnumerator FeverTimeUpdate()
    {
        float feverTime = 1.5f;

        while (true)
        {
            attackSpeed = 0.4f;
            feverTime -= Time.deltaTime;

            if (feverTime <= 0)
            {
                StopFeverTime();
                break;
            }
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

    IEnumerator InitItem()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Instantiate(item);
        }
    }
}
