//FILE : QuestManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 07/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestManager
//PURPOSE :Checks to see what Quests have been done and what quests can be unlocked because of the completed quests. 
public class QuestManager
{
    public bool isCompleted { get; set; }
    public Rescue rescueQuest;
    public Slayer slayerQuest;
    public WinterIsComing wicQuest;
    //FUNCTION : whenComplete()
    //DESCRIPTION : Checking the completed status and assigning the available quests.
    //PARAMETERS : 
    //RETURNS : None()
    public void whenComplete()
    {
        //if (rescueQuest.Completed)
        //{
        //    slayerQuest.currentQuest = true;
        //}

        //will link quests this way when they are all setup to be linked together
    }
}
