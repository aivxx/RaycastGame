using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{

    public AudioSource audioSource;
    public Canvas gameOverMenu;
    public GameObject spawnPoint;

    private void Awake()
    {
        gameOverMenu.enabled = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        transform.position = spawnPoint.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            audioSource.Play();
            gameOverMenu.enabled = true;
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }
}

