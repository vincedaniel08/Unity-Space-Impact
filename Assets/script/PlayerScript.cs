using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 direction;
    public float movespeed = 5;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        BulletSpawn.spawntime = .3f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirectionH = Input.GetAxis("Horizontal");
        float moveDirectionV = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveDirectionH * movespeed, moveDirectionV * movespeed);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * movespeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }

    }
}