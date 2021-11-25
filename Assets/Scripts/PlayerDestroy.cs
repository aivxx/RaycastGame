using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{

    public AudioSource audioSource;
    public Canvas gameOverMenu;


    private void Awake()
    {
        gameOverMenu.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        audioSource.Play();
        gameOverMenu.enabled = true;
    }
}

