using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioHandler : MonoBehaviour
{

    public static AudioHandler Instance;


    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public AudioSource src;

    public AudioClip dieSound;

    public void PlayDieSounds()
    {
        Debug.Log("Is this working??");
        src.PlayOneShot(dieSound);
    }
}