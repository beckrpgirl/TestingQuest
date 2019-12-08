//FILE : QuestGoal.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestGoal
//PURPOSE : The base of what all quest goals are build off of. 
public class QuestGoal
{
    public Quests Quest { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }
    public int CoinReward { get; set; }

    public virtual void Init()
    {
        //default init stuff
    }


//FUNCTION : Evaluate()
//DESCRIPTION : Checking to see if the quest has reached its end
//PARAMETERS : Comparing CurrentAmount with RequiredAmount
//RETURNS : none, if the two match it called Complete
    public void Evaluate()
    {
        Quest.CurrentAmount = CurrentAmount;
        if (CurrentAmount >= RequiredAmount)
            Complete();
    }

//FUNCTION : Complete()
//DESCRIPTION : Changing the quest status to Complete
//PARAMETERS : sets the quest to Complete over the system
//RETURNS : None()
    public void Complete()
    {
        Completed = true;
        Quest.Completed = true;
    }
}
