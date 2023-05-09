using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComporPelota : MonoBehaviour
{
    public void onCollisionEnter(Collision collision){
        if(collision.collider.name == "Pierde"){
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
