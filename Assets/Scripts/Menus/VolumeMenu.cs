using UnityEngine;
using UnityEngine.UI; // Importing necessary UnityEngine namespaces for UI components
using UnityEngine.SceneManagement; // Importing UnityEngine.SceneManagement for scene management
using System.Collections;
using System.Collections.Generic; // Importing necessary namespaces for collections
using TMPro; // Importing TMPro for TextMeshPro support
using Unity.VisualScripting; // Importing TMPro for TextMeshPro support
using UnityEngine.Audio; // Importing UnityEngine.Audio for audio management

public class VolumeMenu : MonoBehaviour
{
    // Reference to the AudioMixer for controlling audio levels
    public AudioMixer audioMixer;

    // Reference to the Slider UI component for volume control
    public Slider masterSlider, musicSlider, sfxSlider;

    // Methods to set the volume levels for Master, Music, and SFX
    public TMP_Text masterText, musicText, sfXText; // TextMeshPro components for displaying volume levels


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float volume = 0f; // Initialize volume variable

        audioMixer.GetFloat("MasterVolume", out volume); // Get the current Master volume level
        masterSlider.value = volume; // Set the slider value to the current Master volume
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
