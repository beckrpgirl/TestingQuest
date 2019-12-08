//FILE : Quest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//NAME : Quest
//PURPOSE : the Parent to the different types of quests. 
public abstract class Quest : MonoBehaviour
{
    public QuestUIManager QUIM;

    public Alison alison;

    public List<QuestGoal> Goals = new List<QuestGoal>();
    public string QuestName { get; set; }
    public string Description { get; set; }
    public string NPCID { get; set; }
    public int ExperenceReward { get; set; }
    public bool currentQuest { get; set; }
    public bool Completed { get; set; }
    public int RequiredAmount { get; set; }
    public int CurrentAmount { get; set; }
    public int CoinReward { get; set; }


//FUNCTION : Anything Text
//DESCRIPTION : Allowing the quests to pass text into the UI
//PARAMETERS : 
//RETURNS : 
    public abstract void StartText();
    public abstract void TrackingQuest();
    public abstract void InprogressText();
    public abstract void CompletedText();


    void Start()
    {
        QUIM = FindObjectOfType<QuestUIManager>();
        alison = FindObjectOfType<Alison>();

    }

//FUNCTION : GiveReward
//DESCRIPTION : gives the player the reward for the quest
//PARAMETERS : 
//RETURNS : 
    public void GiveReward()
    {
        if (alison)
            alison.SetCoin(CoinReward);
    }

    

}
