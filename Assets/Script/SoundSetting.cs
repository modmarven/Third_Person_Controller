using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip roarSound;

    public void SoundEffect()
    {
        audioSource.PlayOneShot(roarSound);
    }
}
