using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject bullet;
    public GameObject player;
    private AudioSource bulletsound;
    public static float spawntime = .3f;
    

    void Start()
    {
        StartCoroutine(randomSpawn());
        bulletsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void spawnObject()
    {
        GameObject a = Instantiate(bullet) as GameObject;
        a.transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
    }
    IEnumerator randomSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);
            spawnObject();
            bulletsounds();
        }
    }

    private void bulletsounds()
    {
        bulletsound.Play();
    }
}