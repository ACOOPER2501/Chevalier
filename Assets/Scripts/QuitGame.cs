using UnityEngine;
using System.Collections.Generic; // Importing necessary namespaces for collections

public class QuitGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Checks if the Escape Key is Pressed.
        {
            Application.Quit(); //Quits the game
        }
        else // If the quit button does not register for some reason
        {
            Debug.Log("Error, did not exit application.");
        }
        
    }
}
