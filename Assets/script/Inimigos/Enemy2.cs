using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed;
    public GameObject PowerUPA;
    public GameObject PowerUPB;
    public int Life = 3;
  
    


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

            if (randomNumber <= 15)
            {
                Instantiate(PowerUPA, transform.position, Quaternion.identity);
                
            }
             else if (randomNumber <= 25)
             {
               Instantiate(PowerUPB, transform.position, Quaternion.identity);
                
             }
        //  else
        //   {
        //       Instantiate(PowerUPC, transform.position, Quaternion.identity);
                
        //   }
    

         if (other.gameObject)
         {
            Life--;


            if(Life < 0)
            {
                Destroy(gameObject);
            }
            
         }
    }
}   