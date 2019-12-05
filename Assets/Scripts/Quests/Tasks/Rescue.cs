using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : Quest
{
    EscortChar BillyBob;
    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Find Billy";
        Description = "Escort Billy Bob back home";
        NPCID = "BillyBob";
        ExperenceReward = 100;
        RequiredAmount = 1;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new EscortQuest(this, NPCID, "Escort Billy back to the village", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

        BillyBob = FindObjectOfType<EscortChar>();
        if (BillyBob)
            BillyBob.Finished = false;

    }
    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello again Alison,";
            QUIM.NPCBoxTwo.text = "Billy Bob wondered off and hasn't come home yet, can you find him?...";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            if (BillyBob.Found == false)
                QUIM.TextDetails.text = "Find Billy and bring him home!";
            if (BillyBob.Found == true)
                QUIM.TextDetails.text = "Thank you, now don't go too fast or you'll lose me!";
            QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you found Billy Bob yet? He was always fascinated by that circle of stones north east of here";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "Billy is home safe and sound.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
