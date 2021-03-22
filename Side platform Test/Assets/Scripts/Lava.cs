using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.rigidbody.CompareTag("Civilian"))
        {
            Destroy(collision.rigidbody.gameObject);
            GameOver();
        }
    }
    public void GameOver ()
     {
         SceneManager.LoadScene("GameOver");
     }
}
