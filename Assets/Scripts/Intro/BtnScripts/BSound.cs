using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;


public class BSound : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnClickBtnSound()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.Play();
    }
}
