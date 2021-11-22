using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInteraction : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.volume = 0.15f;
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
