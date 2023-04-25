using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCubeSpawner : MonoBehaviour
{
    public bool isRunning = true;
    public AudioClip machineToggle;
    public GameObject[] cubePrefabs; // An array to hold the cube prefabs
    public float spawnInterval = 2f; // Time interval between spawns in seconds

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(SpawnRandomCube());
    }

    IEnumerator SpawnRandomCube()
    {
        while (true)
        {
            if (isRunning) {
            // Randomly select a cube prefab from the array
            int randomIndex = Random.Range(0, cubePrefabs.Length - 1);
            GameObject selectedCube = cubePrefabs[randomIndex];

            // Instantiate the selected cube prefab at the spawner's position and rotation
            Instantiate(selectedCube, new Vector3(transform.position.x + 2, transform.position.y + 0.4f, transform.position.z), transform.rotation);

            // Wait for the specified time interval before spawning the next cube
            yield return new WaitForSeconds(spawnInterval); 
            }
        }
    }

    public void ToggleMachine()
    {
        isRunning = !isRunning;
        audioSource.clip = machineToggle;
        audioSource.Play();
    }
}
