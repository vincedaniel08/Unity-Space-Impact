using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBossSpawner : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject boss;
    private AudioSource bulletsound;
    public float spawntime = 1f;

    void Start()
    {
        StartCoroutine(randomSpawn());
        bulletsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void spawnObject()
    {
        GameObject a = Instantiate(bullet) as GameObject;
        a.transform.position = new Vector2(boss.transform.position.x, boss.transform.position.y);

      
    }
    private void spawnObject2()
    {
        GameObject a = Instantiate(bullet2) as GameObject;
        a.transform.position = new Vector2(boss.transform.position.x, boss.transform.position.y);


    }
    private void spawnObject3()
    {
        GameObject a = Instantiate(bullet3) as GameObject;
        a.transform.position = new Vector2(boss.transform.position.x, boss.transform.position.y);


    }
    IEnumerator randomSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);
            spawnObject();
            spawnObject2();
            spawnObject3();
            bulletsounds();
        }
    }

    private void bulletsounds()
    {
        bulletsound.Play();
    }
}