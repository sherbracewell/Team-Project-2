using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheExitDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject player;
    
    void OnTriggerEnter(Collider collide)
    {
        if (collide.CompareTag("Player"))
        {
            if(player.GetComponent<CharController>().civiliansSaved == 5)
            {
                door.transform.position = new Vector3(214, 138, 2);
            }
            
        
        }
    }
}
