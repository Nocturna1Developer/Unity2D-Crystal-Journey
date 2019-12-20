using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    GameObject gameObject; 

    public void OnCollisionEnter2D(Collision2D gameObject) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreTextScript.coinAmount = 0;
    }
}
