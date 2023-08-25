using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject PowerUPA;
    public GameObject PowerUPB;
    public AudioSource audioSourceExplosao;


    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {

            Vector3 direction = (player.transform.position - transform.position).normalized;


            transform.position += new Vector3(direction.x, 0, direction.z) * speed * Time.deltaTime;
        }
    }
    
    
    
    void OnCollisionEnter(Collision other)
    {

            int randomNumber = Random.Range(0, 101); // Gera um número aleatório entre 0 e 100
            Debug.Log(randomNumber);

            if (randomNumber <= 5)
            {
                Instantiate(PowerUPA, transform.position, Quaternion.identity);
                
            }
             else if (randomNumber <= 20)
             {
               Instantiate(PowerUPB, transform.position, Quaternion.identity);
                
             }

        audioSourceExplosao.Play();

         if (other.gameObject)
         {
            Destroy(gameObject);

             GameController gameController = FindObjectOfType<GameController>();
            if (gameController != null) 
            {
                gameController.AddPontos(5); 
            }
            
         }
    }
}   