using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Transform Ebullet;
    public float speed;
    public GameObject EBullet;

    private PlayerLives lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<PlayerLives>();
        Ebullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       Ebullet.position += Vector3.up * -speed;

      

        if (Ebullet.position.y <= -10)
        {
            Destroy(gameObject);
        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                PlayerLives.Lives -= 1;
                Destroy(collision.gameObject);
                Destroy(EBullet);
                
            }
        }

}
