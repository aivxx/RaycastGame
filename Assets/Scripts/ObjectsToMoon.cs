using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToMoon : MonoBehaviour
{

    // object we're placing on the surface
    public Transform objects;

    private void Start()
    {
        Cursor.visible = false;
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    private void FixedUpdate()
    {
        // hit variable to store our results in
        RaycastHit hit;

        // ray from the object to moon
        Ray ray = new Ray(transform.position, transform.up);



        // Conduct raycast
        if (Physics.Raycast(ray, out hit))
        {
            // manipulate the object to place
            objects.position = hit.point;
            // rotate the object to be right side up
            objects.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }

    
    }

}
