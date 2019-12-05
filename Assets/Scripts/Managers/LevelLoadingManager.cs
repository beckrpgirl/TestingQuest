using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoadingManager : MonoBehaviour
{

    public void LoadLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void LoadInstructionsMenu()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadDeathScreen()
    {
        SceneManager.LoadScene("DeathScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
