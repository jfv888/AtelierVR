using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private GameObject machineObject;
    private RandomCubeSpawner randomCubeSpawner;

    void Start()
    {
        // Find the object with the tag "machine"
        machineObject = GameObject.FindGameObjectWithTag("Machine");

        // Get the MachineController component of the object
        randomCubeSpawner = machineObject.GetComponent<RandomCubeSpawner>();
    }

    // Call this method to reverse the isRunning value of the machine object
    public void ToggleMachine()
    {
        if (randomCubeSpawner != null)
        {
            randomCubeSpawner.ToggleMachine();
        }
        else
        {
            Debug.LogWarning("MachineController component not found on the machine object");
        }
    }
}
