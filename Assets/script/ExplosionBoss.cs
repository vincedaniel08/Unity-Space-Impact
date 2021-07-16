using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBoss : MonoBehaviour
{
    public float spawntime = 1f;
  
    public float speed = 10f;
    private AudioSource explosionsound;
    private Rigidbody2D rb;

    IEnumerator Start()
    {
        explosionsound = GetComponent<AudioSource>();
        yield return new WaitForSeconds(spawntime);
        Destroy(this.gameObject);
        explosionsounds();



            
       



    }

    private void explosionsounds()
    {
        explosionsound.Play();
    }


}