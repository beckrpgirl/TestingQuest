using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public abstract class Quest : MonoBehaviour
{
    public QuestUIManager QUIM;

    public Alison alison;

    public List<QuestGoal> Goals = new List<QuestGoal>();
    public string QuestName { get; set; }
    public string Description { get; set; }
    public string NPCID { get; set; }
    public int ExperenceReward { get; set; }  
    public bool Completed { get; set; }
    public int RequiredAmount { get; set; }
    public int CurrentAmount { get; set; }
    public int CoinReward { get; set; }


    public abstract void StartText();
    public abstract void TrackingQuest();
    public abstract void InprogressText();
    public abstract void CompletedText();


    void Start()
    {
        QUIM = FindObjectOfType<QuestUIManager>();
        alison = FindObjectOfType<Alison>();

    }
    public void CheckGoals()
    {
        
        //code to check all tasks are done... isn't working for some reason. 
        //Completed = Goals.All(g => g.Completed);


    }

    public void GiveReward()
    {
        if (alison)
            alison.SetCoin(CoinReward);
    }

    

}
