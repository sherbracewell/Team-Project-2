using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    AudioSource source;
    public AudioClip clip;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.rigidbody.CompareTag("Civilian"))
        {
            Destroy(collision.rigidbody.gameObject);
            source.PlayOneShot(clip);
            GameOver();
        }
    }
    public void GameOver ()
     {
         SceneManager.LoadScene("GameOver");
     }
}
