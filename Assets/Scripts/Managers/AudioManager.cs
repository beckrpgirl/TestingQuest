using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioMixer mixer;
    public AudioSettings[] settings;

    private enum AudioGroups
    {
        Music,
        SFX,
        Ambient
    }

    private void Awake()
    {
        instance = GetComponent<AudioManager>();
    }

    private void Start()
    {
        for (int i = 0; i < settings.Length; i++)
        {
            settings[i].Initialize();
        }
    }

    public void SetMusicVolume(float value)
    {
        settings[(int)AudioGroups.Music].SetExposedParam(value);
    }

    public void SetSFXVolume(float value)
    {
        settings[(int)AudioGroups.SFX].SetExposedParam(value);
    }

    public void SetAmbientVolume(float value)
    {
        settings[(int)AudioGroups.Ambient].SetExposedParam(value);
    }
}

[System.Serializable]
public class AudioSettings
{
    public string exposedParam;
    public Slider slider;

    public void Initialize()
    {
        slider.value = PlayerPrefs.GetFloat(exposedParam);
    }

    public void SetExposedParam(float value)
    {
        AudioManager.instance.mixer.SetFloat(exposedParam, value);
        PlayerPrefs.SetFloat(exposedParam, value);
    }
}

