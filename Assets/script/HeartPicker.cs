using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource lifesound;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "heart")
        {
            lifesound = GetComponent<AudioSource>();
            lifesounds();
            Destroy(other.gameObject);
            Health.health += 1;

        }

    }
    private void lifesounds()
    {
        lifesound.Play();
    }



}
