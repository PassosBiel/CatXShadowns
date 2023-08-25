using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sons : MonoBehaviour
{
    public AudioMixer audio;
    public void Volume(float Volume)
    {
        audio.SetFloat("Volume", Volume);

    }
}