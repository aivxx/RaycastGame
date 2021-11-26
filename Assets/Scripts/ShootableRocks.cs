using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableRocks : MonoBehaviour
{

 

    public GameObject ship;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

    }
}
