using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletDirection;
    [SerializeField]
    private BulletController bulletPool;
    [SerializeField]
    private GameObject spawnPoint;
    [SerializeField]
    public AudioSource[] sounds;
    public AudioSource destroyAudio;
    public AudioSource bulletAudio;
    public Canvas gameWin;

    private Controls controls;
    private bool canShoot = true;
    

    private void Awake()
    {
        controls = new Controls();
        gameWin.enabled = false;
        transform.position = spawnPoint.transform.position;
        sounds = GetComponents<AudioSource>();
        bulletAudio = sounds[1];
    }

 
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.Controller.Fire.performed += _ => PlayerShoot();
    }

    private void PlayerShoot()
    {
        if (!canShoot) return;

        Vector2 mousePosition = controls.Controller.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        GameObject g = bulletPool.GetObject();
        g.transform.position = bulletDirection.position;
        g.transform.rotation = bulletDirection.rotation;
        g.SetActive(true);
        bulletAudio.Play();
        StartCoroutine(CanShoot());
    }

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(.5f);
        canShoot = true;
    }

    private void Update()
    {
        
    }
}
