//FILE : Quests.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



//NAME : Quest
//PURPOSE : the Parent to the different types of quests. 

//[CreateAssetMenu(fileName = "New Quest")]
public class Quests : ScriptableObject
{
    //Items not to be touched. 
    public QuestUIManager QUIM;
    public Alison alison;

    public List<QuestGoal> Goals = new List<QuestGoal>();
    public bool currentQuest { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }

    //Changeable in script able list
    public string QuestName;
    public string Description;
    public string PreviousQuestName;
    public string NPCID;
    public int ExperenceReward;
    public int RequiredAmount;
    public int CoinReward;

    //Descriptions of text
    [TextArea(3,10)]
    public string StartQuestText;
    [TextArea(3, 10)]
    public string TrackingQuestText;
    [TextArea(3, 10)]
    public string InprogressQuestText;
    [TextArea(3, 10)]
    public string CompletedQuestText;


    public virtual void Load() { }

    //FUNCTION : Anything Text
    //DESCRIPTION : Allowing the quests to pass text into the UI
    //PARAMETERS : 
    //RETURNS : 
    public virtual void StartText() { }
    public virtual void TrackingQuest(){ }
    public virtual void InprogressText() { }
    public virtual void CompletedText() { }


    void OnEnable()
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
        alison = FindObjectOfType<Alison>();
        if (alison)
            alison.SetCoin(CoinReward);
    }



}
