using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text txtPontos;
    public int pontos;
    public int pontosAdd = 200;
    public string nome;

    public GameObject[] objetosParaDestruir;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        if (txtPontos == null)
        {
            txtPontos = GameObject.Find("txtPontos").GetComponent<Text>();
        }

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F))
        {
            pontos += pontosAdd;
            Debug.Log("Nova contagem de pontos: " + pontosAdd);




        }

        if (pontos >= 200)
        {
            SceneManager.LoadScene("Fase2");
        }


        if (pontos >= 250)
        {
            SceneManager.LoadScene("Vitoria");
        }
        
    }



    public void AddPontos(int p)
    {
        pontos += p;
        if (txtPontos != null)
        {
            txtPontos.text = "Pontos: " + pontos;
        }

        
    }


}
