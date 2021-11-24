using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RaycastShooter : MonoBehaviour
{

    private void FixedUpdate()
    {

        if (Input.GetButtonDown("Fire"))
            {
            Shoot();
        }
    }

    void Shoot() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(transform.position, ray.direction * hit.distance, Color.red);

        }
        else
        {
            Debug.DrawLine(transform.position, ray.direction * 1000, Color.yellow);
        }
    }

}




