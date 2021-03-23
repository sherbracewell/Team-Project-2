using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpentheDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject lava;
    
    void OnTriggerEnter(Collider collide)
    {
        if (collide.CompareTag("Player"))
        {
            door.transform.position = new Vector3(139, 16, 2);
            lava.SetActive(false);
            Timer.instance.SetTimerRunning(true);
        }
    }

}
