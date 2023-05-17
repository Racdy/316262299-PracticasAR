using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComporPelota : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Pierde")){
            Destroy(this.gameObject);
            Debug.Log("La esfera colisionó con el fondo: PIERDE");
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("PuntoFinal"))
        {
            Debug.Log("La esfera colisionó con la meta del nivel: PUNTO FINAL");
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
