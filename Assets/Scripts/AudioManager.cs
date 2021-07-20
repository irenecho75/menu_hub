using UnityEngine.Audio;
using UnityEngine;
//using System;
//using UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public AudioClip clip; 

    // Awake is called before Start
    void Awake()
    {

    }

    public void PlayMoleSound(AudioSource aSource) {


        //set the clip -> call rand and get an random index to index into clip array
        aSource.clip = clip;
        aSource.volume = Random.Range(0.5f,1f);
        aSource.pitch = Random.Range(0.5f,1f);
        aSource.Play();
        //set the volume,pitch, etc.
        //play
    }  
}
