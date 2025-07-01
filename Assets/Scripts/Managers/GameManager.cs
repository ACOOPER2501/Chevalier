using UnityEngine;
using TMPro; // Importing TMPro for TextMeshPro support
using UnityEngine.UI; // Importing necessary UnityEngine namespaces for UI components
using UnityEngine.SceneManagement; // Importing UnityEngine.SceneManagement for scene management
using System.Collections;
using System.Collections.Generic; // Importing necessary namespaces for collections
using Unity.VisualScripting;
using UnityEngine.Events; // Importing TMPro for TextMeshPro support

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int startingLives = 3; // Starting lives for the player

    public int currentLives; // Current lives of the player

    public GameObject gameOverText; // Reference to the Game Over text object

    public GameObject victoryText; // Reference to the Victory text object

    public GameObject playerPawn; // Reference to the player prefab

   // public Transform respawnPoint; // Reference to the respawn point for the player





    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // Set the singleton instance
            DontDestroyOnLoad(gameObject); // Prevent this object from being destroyed on scene load
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }



    // Update is called once per frame
    void Update()
    {

    }


    //private bool gameEnded = false;

    public void PlayerDied()
    {
        //Death Code Here
    }


}
