using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slayer : Quest
{

    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Bandit Basher";
        Description = "Clear out the bandit camp";
        NPCID = "Enemy";
        ExperenceReward = 100;
        RequiredAmount = 4;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new KillQuest(this, NPCID, "Kill " + RequiredAmount + " Bandits", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

    }

    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Welcome Alison,";
            QUIM.NPCBoxTwo.text = "There is a group of bandits camped near us, can you deal with them?";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            QUIM.TextDetails.text = "Clear out the bandit camp";
            QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you had any luck defeating those bandits?";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "You have saved our village.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
