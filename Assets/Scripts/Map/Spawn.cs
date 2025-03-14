using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] itemsToSpawn; // Array of items to spawn
    public Vector3 spawnAreaMin; // Minimum position of the spawn area
    public Vector3 spawnAreaMax; // Maximum position of the spawn area
    public Transform spawnPoint;
    public float spawnInterval = 0.5f; // Interval between spawns
    private float timer = 0f;
    
   

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn
        if (timer >= spawnInterval)
        {
            // Reset the timer
            timer = 0f;

            // Spawn a random item within the spawn area
            int randomItemIndex = Random.Range(0, itemsToSpawn.Length);
            GameObject newItem = Instantiate(itemsToSpawn[randomItemIndex], spawnPoint.position, itemsToSpawn[randomItemIndex].transform.rotation);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        return spawnPoint.position;
    }
    void OnDrawGizmosSelected()
    {
        // Draw the spawn area gizmo in the Unity Editor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, spawnAreaMax - spawnAreaMin);
    }



}
