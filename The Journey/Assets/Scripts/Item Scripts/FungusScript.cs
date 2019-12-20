using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FungusScript : MonoBehaviour
{
    //AudioSource audioSource;

     //void Start () 
     //{
     //    audio = GetComponent<AudioSource>();
     //}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreTextScript.coinAmount -= 15;
        //GetComponent<AudioSource>().PlayOneShot(audioSource);
        Destroy(gameObject);
    }
}
