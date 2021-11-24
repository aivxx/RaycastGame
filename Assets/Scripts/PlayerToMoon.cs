using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerToMoon : MonoBehaviour
{

    // object we're placing on the surface
    public Transform objectToPlace;

      private void Start()
    {
            Cursor.visible = false;
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    private void FixedUpdate()
    {
        // hit variable to store our results in
        RaycastHit hit;

        // ray from the camera to world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

 

        // Conduct raycast
        if (Physics.Raycast(ray, out hit))
        {
            // manipulate the object to place
            objectToPlace.position = hit.point;
            // rotate the object to be right side up
            objectToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }
    }

}

