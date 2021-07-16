using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject enemybullet;
    public GameObject enemy;

    public float spawntime = 1f;

    void Start()
    {
        StartCoroutine(randomSpawn());
    }

    // Update is called once per frame
    private void spawnObject()
    {
        GameObject a = Instantiate(enemybullet) as GameObject;
        a.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
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