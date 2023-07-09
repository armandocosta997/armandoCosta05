using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
public GameObject EnemyBulletPrefab;
public float fireRate = 3f;
private float nextFireTime = 0f;

// Start is called before the first frame update
void Start()
{
    // Set the initial next fire time
    nextFireTime = Time.time + fireRate;
}

// Update is called once per frame
void Update()
{
    // Check if it's time to shoot
    if (Time.time >= nextFireTime)
    {
        // Instantiate the bullet
        Instantiate(EnemyBulletPrefab, transform.position, Quaternion.identity);

        // Update the next fire time
        nextFireTime = Time.time + fireRate;
    }
}
}