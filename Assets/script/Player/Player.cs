using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Life Player :
    public int maxHealth = 3;
    public int currentHealth;
    public float speed;
    public enum TipoTiro {SINGLE, DUPLO, TRIPLO };
    public GameObject gunPrefab;
    private TipoTiro tiro;
    public Text texto;
    public GameObject objetoPai;
    public GameObject objetoFilho;
    public GameObject objetoFilho2;
    public GameObject objetoPai2;
    public GameObject objetoFilho3;
    public GameObject objetoFilho4;


    void Start()
    {
        currentHealth = maxHealth;
        texto = GameObject.Find("Life").GetComponent<Text>();
        texto.text = currentHealth.ToString();
    }

    void AtivarObjetoFilho()
    {
        objetoFilho.SetActive(true);
        objetoFilho2.SetActive(true);
    }
    
    void AtivarObjetoFilho2()
    {
        objetoFilho3.SetActive(true);
        objetoFilho4.SetActive(true);
    }


    void Update()
    {
        texto.text = currentHealth.ToString();

        //Movimentação
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(h, 0, v) * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PowerUPLife"))
        {
            Destroy(collision.gameObject);
            currentHealth++;
        }

        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
            currentHealth--;
            texto.text = currentHealth.ToString();
            if (currentHealth == 0)
            {
                SceneManager.LoadScene(1);
            }
        }

        if (collision.gameObject.CompareTag("boss"))
        {
            currentHealth--;
            currentHealth--;
            currentHealth--;
            currentHealth--;
            currentHealth--;
            if (currentHealth < 0)
            {
                SceneManager.LoadScene("Derrota");
            }
        }

        if (collision.gameObject.CompareTag("PowerUpTiro"))
        {
            Destroy(collision.gameObject);
            tiro++;

            Vector3 pos = transform.position;

            switch (tiro)
            {
                case TipoTiro.DUPLO:

                    AtivarObjetoFilho();

                    break;
                case TipoTiro.TRIPLO:

                    AtivarObjetoFilho2();

                    break;
            }
        }
    }
}
