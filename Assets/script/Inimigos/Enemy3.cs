using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy3 : MonoBehaviour
{
    public float speed;
    int Life = 75;
    public Animator animator;
    public GameObject objetoFilho;
    public GameObject objetoFilho2;
    public GameObject objetoFilho3;


    void AtivarObjetoFilho()
    {
        objetoFilho.SetActive(true);
        objetoFilho2.SetActive(true);
        objetoFilho3.SetActive(true);
    }





    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {

            Vector3 direction = (player.transform.position - transform.position).normalized;


            transform.position += new Vector3(direction.x, 0, direction.z) * speed * Time.deltaTime;
        }

            if (Life < 45) 
            {
            AtivarObjetoFilho();
            speed = 3;
            } 
            if (Life < 20) 
            {
            speed = 5;
            }


            if (Life < 0)
            {
            SceneManager.LoadScene("Vitoria");
            }
    }
    
    
    
    void OnCollisionEnter(Collision other)
    {
    

         if (other.gameObject)
         {
            Life--;
            
         }
    }
}   