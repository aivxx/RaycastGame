using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootableRocks : MonoBehaviour
{

    public AudioSource rocksDestroyedAudio;
    

   

    private void OnTriggerEnter(Collider other)
    {
        rocksDestroyedAudio.Play();
      
        Destroy(gameObject);

    }

   

    
}
