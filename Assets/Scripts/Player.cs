using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    public Controls controls;

    private void Awake()
    {
        controls.Controller.Fire.performed += ctx => Shoot();
    }

    void Shoot()
    {
        Debug.Log("hit");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
