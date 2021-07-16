using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject asteroid;
    public float spawntime = 1f;

    void Start()
    {
        StartCoroutine(randomSpawn());
    }

    // Update is called once per frame
    private void spawnObject()
    {
        GameObject a = Instantiate(asteroid) as GameObject;
        a.transform.position = new Vector2(10, Random.Range(-5.0f, 5.0f));
    }
    IEnumerator randomSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);
            spawnObject();
        }
    }
}