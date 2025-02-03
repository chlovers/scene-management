using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public string SpawnPoint;
    public string scenes;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.levelManager.Loadscenesp(scenes, SpawnPoint);
        }
    }

}
