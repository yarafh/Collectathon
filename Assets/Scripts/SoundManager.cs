using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip playerJump, coinCollect, winSound, hazardSound;

    private void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

    public void PlayPlayerJump()
    {
        audioSource.PlayOneShot(playerJump);
    }
    
    public void PlayCoinCollect()
    {
        audioSource.PlayOneShot(coinCollect);
    }

    public void PlayWinSound()
    {
        audioSource.PlayOneShot(winSound);
    }

    public void PlayHazardSound()
    {
        audioSource.PlayOneShot(hazardSound);
    }

    private void Update()
    {
        
    }
}
