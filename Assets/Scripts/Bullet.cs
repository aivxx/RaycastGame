using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;

    private BulletController pool;

    private void Start()
    {
        pool = transform.parent.GetComponent<BulletController>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        pool.ReturnObject(gameObject);
    }  
    private void OnEnable()
    {
        StartCoroutine(DestroyBulletAfterTime());
    } 
    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(3f);
        pool.ReturnObject(gameObject);
    }

  
}
