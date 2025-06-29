using UnityEngine;
using UnityEngine.Audio; // Importing UnityEngine.Audio for audio management

public class AudioManager : MonoBehaviour
{
    
    public AudioMixer audioMixer; // Reference to the AudioMixer for managing audio levels

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume")) // Check if Master volume setting exists in PlayerPrefs
        {
            audioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume")); // Set the Master volume in the AudioMixer
        }


        if (PlayerPrefs.HasKey("MusicVolume")) // Check if Music volume setting exists in PlayerPrefs
        {
            audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume")); // Set the Music volume in the AudioMixer
        }


        if (PlayerPrefs.HasKey("SFXVolume")) // Check if SFX volume setting exists in PlayerPrefs
        {
            audioMixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume")); // Set the SFX volume in the AudioMixer
        }
    }

}
