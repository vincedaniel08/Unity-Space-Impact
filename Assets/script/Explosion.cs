using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float spawntime = 1f;
    public GameObject coin;
    public float speed = 10f;
    private AudioSource explosionsound;
    private Rigidbody2D rb;

    IEnumerator Start()
    {
        explosionsound = GetComponent<AudioSource>();
        yield return new WaitForSeconds(spawntime);
        Destroy(this.gameObject);
        explosionsounds();



        Instantiate(coin, transform.position, Quaternion.identity);
        
       
       

    }

    private void explosionsounds()
    {
       explosionsound.Play();
    }


}