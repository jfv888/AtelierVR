using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    private bool isOnConveyor;

    private void Update()
    {
        if (isOnConveyor)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Conveyor"))
        {
            isOnConveyor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Conveyor"))
        {
            isOnConveyor = false;
        }
    }
}
