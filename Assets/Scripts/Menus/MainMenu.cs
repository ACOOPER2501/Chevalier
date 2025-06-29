using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // This method is called when the "New Game" button is clicked in the main menu.
    public void NewGame()
    {
        //Load the Level One scene to start a new game.
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelOne");
    }

    // This method is called when the "Quit" button is clicked in the main menu.
    public void QuitGame()
    {
        // Quit the application.
        Application.Quit();

        // If running in the editor, stop playing the scene.
        Debug.Log("Game is quitting...");
    }
}
