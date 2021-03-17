using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public GameObject player;
    public GameObject pauseMenu;

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Resume()
   {
      pauseMenu.SetActive(false);
      player.SetActive(true);
      //have to add script for the lava after we make it
   }
}
