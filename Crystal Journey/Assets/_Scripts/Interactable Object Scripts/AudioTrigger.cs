using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip collideSound;

    private AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<AudioSource>().PlayOneShot(collideSound);
        Destroy(gameObject);
    }
}

