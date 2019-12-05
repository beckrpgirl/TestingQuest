using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal
{
    public Quest Quest { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }
    public int CoinReward { get; set; }

    public virtual void Init()
    {
        //default init stuff
    }

    public void Evaluate()
    {
        Quest.CurrentAmount = CurrentAmount;
        if (CurrentAmount >= RequiredAmount)
            Complete();
    }

    public void Complete()
    {
        Completed = true;
        Quest.Completed = true;
        //Quest.CheckGoals();

    }



}
