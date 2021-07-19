using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
// In order to make a custom class appear in the inspector
public class Sound {

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Range(.1f, 1f)]
    public float pitch;


    [HideInInspector]
    public AudioSource source;
}