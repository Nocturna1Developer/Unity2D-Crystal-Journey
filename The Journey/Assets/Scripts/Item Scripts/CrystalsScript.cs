using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrystalsScript : MonoBehaviour
{
    //[SerializeField] AudioClip collected;
    public AudioSource audioSource;

    void Start () 
     {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreTextScript.coinAmount += 20;
        Destroy(gameObject);
        audioSource.Play();
        if(ScoreTextScript.coinAmount >= 180)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            ScoreTextScript.coinAmount = 0;
        }

        // if (collision.gameObject.tag == "Player")
        // {
        //     audioSource.Play();
        // }
    }
}
