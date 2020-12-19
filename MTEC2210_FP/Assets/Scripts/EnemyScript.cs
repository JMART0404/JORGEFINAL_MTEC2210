using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    float timer = 0;
    float Movetime = 0.5f;
    int numMove = 0;
    float speed = 0.25f;

    public Transform EnemyShot;
    public GameObject EnemyBullet;
    private float nextfire;
    public float FireRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > Movetime && numMove < 22)
        {
           transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numMove++;

        }

        if(numMove == 22)
        {
            transform.Translate(new Vector3(0, -1, 0));
            numMove = -1;
            speed = -speed;
            timer = 0;
        }

       // FireEnemy();
    }


    void FireEnemy()
    {
        if (Random.Range(0f,500f) < 1)
        {
            nextfire = Time.time + FireRate;
            Instantiate(EnemyBullet, EnemyShot.position, EnemyShot.rotation);
          
        }
    }

 
}
