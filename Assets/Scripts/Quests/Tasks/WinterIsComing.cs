using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterIsComing : Quest
{
    // Start is called before the first frame update
    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Winter Wooderland";
        Description = "Collect wood";
        ExperenceReward = 100;
        RequiredAmount = 6;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new CollectingQuest(this, "wood", "Gather up " + RequiredAmount + " wood", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

    }

    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Welcome Alison,";
            QUIM.NPCBoxTwo.text = "Winter is Coming, the town needs fire wood to brave the coming cold, collect " + RequiredAmount + " of logs from the nearby woods";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            QUIM.TextDetails.text = "Collect " + RequiredAmount + " wood";
            QUIM.TextTally.text = CurrentAmount + " / " + RequiredAmount;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you had any luck getting the wood?";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "We shall not need any more wood.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
