using System.Collections;
using System.Collections.Generic; // Importing necessary namespaces for collections
using TMPro; // Importing TMPro for TextMeshPro support
using Unity.VisualScripting; // Importing TMPro for TextMeshPro support
using UnityEngine;
using UnityEngine.Audio; // Importing UnityEngine.Audio for audio management
using UnityEngine.SceneManagement; // Importing UnityEngine.SceneManagement for scene management
using UnityEngine.UI; // Importing necessary UnityEngine namespaces for UI components

public class VolumeMenu : MonoBehaviour
{
    // Reference to the AudioMixer for controlling audio levels
    public AudioMixer audioMixer;

    // Reference to the Slider UI component for volume control
    public Slider MasterSlider, MusicSlider, SFXSlider;

    // Methods to set the volume levels for Master, Music, and SFX
    public TMP_Text MasterNumber, MusicNumber, SFXNumber; // TextMeshPro components for displaying volume levels


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float volume = 0f; // Initialize volume variable

        audioMixer.GetFloat("MasterVolume", out volume); // Get the current Master volume level
        MasterSlider.value = volume; // Set the slider value to the current Master volume

        audioMixer.GetFloat("MusicVolume", out volume); // Get the current Music volume level
        MusicSlider.value = volume; // Set the slider value to the current Music volume

        audioMixer.GetFloat("SFXVolume", out volume); // Get the current SFX volume level
        SFXSlider.value = volume; // Set the slider value to the current SFX volume

        // Update the text components to display the current volume levels
        //We add 80 to the volume because the AudioMixer expects a range of -80 to 0 for volume levels
        MasterNumber.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();
        MusicNumber.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();
        SFXNumber.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Method to set the Master volume level
    public void SetMasterVolume()
    {
        // Set the Master volume in the AudioMixer based on the value of the mastSlider
        //Mathf.RoundToInt(mastSlider.value + 80) converts the slider value to a range suitable for the AudioMixer
        //Mathf.RoundToInt rounds the value to the nearest integer, so the player will see whole numbers in the UI
        //We add 80 because the AudioMixer expects a range from -80 to 0 for volume levels
        //This way, we can have our slider range from 0 to 80, which is more user-friendly
        MasterNumber.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();

        //This will store the current value of the master volume slider
        audioMixer.SetFloat("MasterVolume", MasterSlider.value); // Set the Master volume level based on the slider value

        //This stores the Master Volume setting in PlayerPrefs
        PlayerPrefs.SetFloat("MasterVolume", MasterSlider.value); // Save the Master volume level to PlayerPrefs
    }

    // Method to set the Music volume level
    public void SetMusicVolume()
    {
        // This method sets the Music volume in the AudioMixer based on the value of the musicSlider
        MusicNumber.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();

        // Allows the AudioMixer to set the Music volume based on the slider value
        audioMixer.SetFloat("MusicVolume", MusicSlider.value);

        //This stores the Music volume setting in PlayerPrefs, so that it can be saved and loaded later between game sessions.
        PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
    }

    // Method to set the SFX volume level
    public void SetSFXVolume()
    {
        // This method sets the SFX volume in the AudioMixer based on the value of the sfxSlider
        SFXNumber.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();

        // Allows the AudioMixer to set the SFX volume based on the slider value
        audioMixer.SetFloat("SFXVolume", SFXSlider.value);

        //This stores the SFX volume setting in PlayerPrefs, so that it can be saved and loaded later between game sessions.
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }

}
