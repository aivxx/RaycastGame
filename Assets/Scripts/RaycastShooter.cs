using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{

    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    private Camera camera;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);
    private AudioSource gunAudio;
    private LineRenderer laserLine;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
        camera = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            StartCoroutine(ShotEffect());

            Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            if(Physics.Raycast(rayOrigin, camera.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition(1, hit.point);
            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (camera.transform.forward * weaponRange));
            }

        }

    }

    private IEnumerator ShotEffect()
    {
        gunAudio.Play();

        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
