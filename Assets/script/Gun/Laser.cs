using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;

    //LaserDirection, DestroyTime

    void Start()
    {
        Destroy(this.gameObject, 2.0f);

    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    //DestroiBullet

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}