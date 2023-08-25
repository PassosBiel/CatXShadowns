using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInimigo : MonoBehaviour
{
    public GameObject laser;
    public Transform gun;
    public float intervaloDeTiro = 10f;

    private float tempoDecorrido = 10f;

    void Update()
    {
        tempoDecorrido += Time.deltaTime;

        if (tempoDecorrido >= intervaloDeTiro)
        {
            Atirar();
            tempoDecorrido = 0f;
        }
    }

    void Atirar()
    {
        Instantiate(laser, gun.position, gun.rotation);
    }
}
