﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{

    public string name;

    public AudioClip clip;
    public AudioMixerGroup output;

    [Range(0f, 1f)]
    public float volum;
    [Range(0.1f, 3f)]
    public float pitch;
    [Range(0f, 1f)]
    public float spatialBlend;


    [HideInInspector]
    public AudioSource source;

    public bool loop;

}
