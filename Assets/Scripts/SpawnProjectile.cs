using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject projectile;
    public float maxX, minX, maxY, minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        Instantiate(projectile, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
