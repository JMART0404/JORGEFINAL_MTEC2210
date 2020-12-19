using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    //public GameObject Bullet;

    private PlayerScore score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<PlayerScore>();
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.position += Vector3.up * speed;

        if (bullet.position.y >= 10)
        {
            Destroy(gameObject);
        }

    }
       void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Enemy")
            {

                PlayerScore.Score += 1;
                Destroy(other.gameObject);
                Destroy(gameObject);
                
            }
        }

}
