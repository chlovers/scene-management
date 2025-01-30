using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour

{
    public GameObject mikebobble;

    public void Playbutton()
    {
        SceneManager.LoadScene("GamePlay");

    }

    public void Quitbutton()
    {
        Application.Quit();

    }

    private void Update()
    {
       if(Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);
            spawnplayerGP();
        }

       if(Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);
            spawnplayermenu();
           
        }


    }
 

    public void spawnplayerGP()
    {
     GameObject spwan =  GameObject.Find("SpawnPointGP");
        
        mikebobble.transform.position = spwan.transform.position;
    }

    public void spawnplayermenu()
    {
        GameObject spwan = GameObject.Find("SpawnPointMenu");
        Debug.Log("spawned");
        mikebobble.transform.position = spwan.transform.position;
    }
}

