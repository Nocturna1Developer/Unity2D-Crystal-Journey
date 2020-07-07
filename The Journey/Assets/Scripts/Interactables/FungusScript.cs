using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FungusScript : MonoBehaviour
{
    AudioSource audioSource;

     void Start () 
     {
         audioSource = GetComponent<AudioSource>();
     }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreTextScript.coinAmount -= 15;
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            //collision.audioSource.Play();
            //Destroy(gameObject);
        }
        
    }
}
