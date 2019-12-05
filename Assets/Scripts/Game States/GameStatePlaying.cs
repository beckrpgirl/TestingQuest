using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatePlaying : GameState
{

    public GameStatePlaying(GameManager manager) : base(manager) { }

    public override void OnStateEnter()
    {
        Cursor.visible = gameManager.isPaused;
    }

    public override void OnStateExit()
    {

    }

    public override void OnStateUpdate()
    {

        if (gameManager.isPaused == false)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameManager.isPaused = !gameManager.isPaused;
                gameManager.DisplayPauseMenu(gameManager.isPaused);
            }
            Time.timeScale = gameManager.isPaused ? 0.0f : 1.0f;
        }

    }
}

