using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public GameObject player;
    public GameObject pauseMenu;
    public GameObject lava;
    public GameObject bgmusic;

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Resume()
   {
      pauseMenu.SetActive(false);
      player.SetActive(true);
      lava.SetActive(true);
      bgmusic.SetActive(true);
   }
}
