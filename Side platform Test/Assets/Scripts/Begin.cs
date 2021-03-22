using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
   public GameObject Lava;
   public GameObject door;

   void OnTriggerEnter(Collider collide)
    {
        if (collide.CompareTag("Player"))
        {
            door.transform.position = new Vector3(139, 16, 0);
            Lava.SetActive(true);
            Lava.transform.position = new Vector3(0, 0, 0);
        }
    }
}
