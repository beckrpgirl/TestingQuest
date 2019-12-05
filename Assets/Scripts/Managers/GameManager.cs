using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    public GameStatePlaying stateGamePlaying { get; set; }

    private GameState currentState;
    // Start is called before the first frame update

    public void Awake()
    {
        stateGamePlaying = new GameStatePlaying(this);
    }
    void Start()
    {
        NewGameState(stateGamePlaying);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != null)
        {
            currentState.OnStateUpdate();
        }
    }

    public void NewGameState(GameState newState)
    {
        if (null != currentState)
        {
            currentState.OnStateExit();
        }
        currentState = newState;
        currentState.OnStateEnter();
    }

    public void DisplayPauseMenu(bool isPaused)
    {
        if (settingsMenu.activeInHierarchy)
        {
            settingsMenu.SetActive(false);
            isPaused = true;
        }
        Cursor.visible = isPaused;
        pauseMenu.SetActive(isPaused);
    }

    public void ResumeGame()
    {
        if (pauseMenu.activeInHierarchy || settingsMenu.activeInHierarchy)
        {
            if (pauseMenu.activeInHierarchy)
            {
                pauseMenu.SetActive(false);

            }
            else if (settingsMenu.activeInHierarchy)
            {
                settingsMenu.SetActive(false);
            }
        }
        isPaused = false;
    }

    public void DisplaySettingsMenu()
    {
        if (pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            settingsMenu.SetActive(true);

        }
        else
        {
            settingsMenu.SetActive(false);
            pauseMenu.SetActive(true);
        }

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
