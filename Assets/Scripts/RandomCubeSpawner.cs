using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCubeSpawner : MonoBehaviour
{
    public GameObject[] cubePrefabs; // An array to hold the cube prefabs
    public float spawnInterval = 2f; // Time interval between spawns in seconds

    void Start()
    {
        StartCoroutine(SpawnRandomCube());
    }

    IEnumerator SpawnRandomCube()
    {
        while (true)
        {
            // Randomly select a cube prefab from the array
            int randomIndex = Random.Range(0, cubePrefabs.Length);
            GameObject selectedCube = cubePrefabs[randomIndex];

            // Instantiate the selected cube prefab at the spawner's position and rotation
            Instantiate(selectedCube, new Vector3(transform.position.x + 2, transform.position.y + 0.4f, transform.position.z), transform.rotation);

            // Wait for the specified time interval before spawning the next cube
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
