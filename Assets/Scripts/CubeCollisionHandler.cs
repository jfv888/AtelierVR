using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionHandler : MonoBehaviour
{
    public AudioClip goodCubeSound;
    public AudioClip badCubeSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GoodCube"))
        {
            audioSource.clip = goodCubeSound;
            audioSource.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("BadCube"))
        {
            audioSource.clip = badCubeSound;
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }
}
