using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBoard : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip sound1;

    private void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

    private void Update()
    {
        MusicPlayer();

        if(Input.GetKeyDown(KeyCode.Alpha4))
            audioSource.PlayOneShot(sound1);
    }

    private void MusicPlayer()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            audioSource.Play();
        else if(Input.GetKeyDown(KeyCode.Alpha2))
            audioSource.Stop();
        else if(Input.GetKeyDown(KeyCode.Alpha3))
            audioSource.Pause();
    }
}
