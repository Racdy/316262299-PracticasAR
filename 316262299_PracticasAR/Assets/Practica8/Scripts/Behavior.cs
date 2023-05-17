using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lose"))
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Win"))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}

