using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{

    protected GameManager gameManager;

    public GameState(GameManager gm)
    {

        gameManager = gm;

    }

    public abstract void OnStateEnter();
    public abstract void OnStateExit();
    public abstract void OnStateUpdate();

}
