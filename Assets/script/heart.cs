using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    private Rigidbody2D rb;
    private AudioSource lifesound;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);

    }

    // Update is called once per frame
    void Update()
    {



        if (transform.position.x < -30)
        {
            Destroy(this.gameObject);
        }

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            lifesound = GetComponent<AudioSource>();
            lifesounds();
            Health.health += 1;
            BulletSpawn.spawntime -= .1f;
           
              

        }
       

    }
       
    private void lifesounds()
    {
        lifesound.Play();
       
    }



}