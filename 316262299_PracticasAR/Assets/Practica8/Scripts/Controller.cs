using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject pelotas;
    public GameObject prePelota;
    public Transform posicionInicial;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pelotas == null)
        {
            pelotas = Instantiate(prePelota, posicionInicial) as GameObject;
        }
    }
}
