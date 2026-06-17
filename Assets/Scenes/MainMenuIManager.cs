using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuIManager : MonoBehaviour
{
    // Button 1 - Beginner
    public void LoadBeginner()
    {
        SceneManager.LoadScene("Beginner");
    }

    // Button 2 - Advanced
    public void LoadAdvanced()
    {
        SceneManager.LoadScene("Advanced");
    }

    // Button 3 - Expert
    public void LoadExpert()
    {
        SceneManager.LoadScene("Expert");
    }

    // Button 4 - Quit Game
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
