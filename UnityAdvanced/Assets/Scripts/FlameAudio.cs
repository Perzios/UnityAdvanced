﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAudio : MonoBehaviour
{

    public AudioClip burn;
    public AudioSource source;

    private void Awake()
    {
        source.clip = burn;
        source.Play();
    }

    public void StopPlay()
    {
        source.Stop();
    }
}
