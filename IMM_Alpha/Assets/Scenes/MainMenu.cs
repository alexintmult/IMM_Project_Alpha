using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/alexintmult/IMM_Project_Alpha"); // Replace with your GitHub link
    }
}
