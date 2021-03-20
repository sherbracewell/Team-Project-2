using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody.CompareTag("Player") || collision.rigidbody.CompareTag("Civilian"))
        {
            Destroy(collision.rigidbody.gameObject);
        }
    }
}
