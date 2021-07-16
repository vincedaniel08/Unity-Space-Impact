using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    // Start is called before the first frame u/d..
 
    private  AudioSource coinsound;
  


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")
        {
            coinsound = GetComponent<AudioSource>();
            coinsounds();
            Destroy(other.gameObject);
            Score.score++;

        }

            
      


    }
   private void coinsounds()
    {
        coinsound.Play();
    }



   
}
