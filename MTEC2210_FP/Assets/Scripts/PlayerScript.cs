using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public float playerSpeed;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextfire;
    private AudioSource audioSource;
    private PlayerScore Score;

  
    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        Vector3 moveHorizontal = new Vector3(xMovement, 0, 0);
        transform.position += playerSpeed * moveHorizontal * Time.deltaTime;


        if (Input.GetButton("Fire1") && Time.time > nextfire)
        {
            audioSource.Play();
            nextfire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            nextfire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            
        }

        

    }
 
}
