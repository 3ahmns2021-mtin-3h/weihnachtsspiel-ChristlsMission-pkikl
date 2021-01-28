using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject parentEnemy;

    public float nextSpawn = 10.0f;
    public float spawnRate = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTheEnemies();
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheEnemies();
        }
    }

    private void SpawnTheEnemies()
    {
        var clones = Instantiate(enemyPrefab);
        clones.GetComponent<Transform>().SetParent(parentEnemy.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 400, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
