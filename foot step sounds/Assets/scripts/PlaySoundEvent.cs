using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlaySoundEvent : MonoBehaviour
{
    public AudioClip mySound;
    public AudioSource mySource;

    private void Awake()
    {
        mySource = GetComponent<AudioSource>();
    }

    void Step()
    {
        mySource.clip = mySound;
        mySource.Play();
    }
}
