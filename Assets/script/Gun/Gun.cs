using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject laser;
    public Transform gun;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }  
    void Atirar()
    {
        Instantiate(laser, gun.position, gun.rotation);    
    }
}
