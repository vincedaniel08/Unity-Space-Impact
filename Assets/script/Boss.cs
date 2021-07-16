using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    private Rigidbody2D rb;
    public GameObject explosionBoss;
    public static float healthAmount;
    public GameObject heart;

    void Start()
    {
        healthAmount = 0.1917742f;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
       
    }


    // Update is called once per frame
    void Update()
    {


        if (transform.position.x < -20)
        {
            Destroy(this.gameObject);
        }

        if (healthAmount <= 0)
        {
            Destroy(gameObject);
            Instantiate(heart, transform.position, Quaternion.identity);
          
        }
            

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject a = Instantiate(explosionBoss);
            a.transform.position = this.transform.position;
            Health.health = 0;
          
            Destroy(this.gameObject);
            
        }

        if (collision.tag == "PlayerBullet")
        {
            healthAmount -= 0.01f;
        }

            



    }

}