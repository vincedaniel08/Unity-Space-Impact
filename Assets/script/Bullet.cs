using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody2D rb;
    public GameObject explosion;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }
    private void Update()
    {
        if (transform.position.x > 10)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.tag == "Enemy")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }


        if (collision.tag == "Boss")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

           
            Destroy(this.gameObject);
        }


        if (collision.tag == "Boss1")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;


            Destroy(this.gameObject);
        }
        if (collision.tag == "Boss2")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

            Destroy(this.gameObject);
        }
        if (collision.tag == "Boss3")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

            Destroy(this.gameObject);
        }
        if (collision.tag == "Boss4")
        {
            GameObject a = Instantiate(explosion);
            a.transform.position = this.transform.position;

            Destroy(this.gameObject);
        }
    }

}