//FILE : QuestGiver.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestGiver
//PURPOSE : Controls the handing out and dialog of the character. 
public class QuestGiver : NPCController
{
    //UI and Quests.cs to link to
    //QuestUIManager QUIM;
    //QuestManager QM;
    QuestGiverScript QGS;

    //public Quests Quest { get; set; }
    //public bool AssignedQuest { get; set; } //Has quest been assigned
    //public bool Helped { get; set; } //quest to hand in
    //public List<Quests> QuestList = new List<Quests>(); //List of quests for NPC
    //int i = 0; //quest counter


    void Awake()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //QM = FindObjectOfType<QuestManager>();
        QGS = FindObjectOfType<QuestGiverScript>();
    }
    //Interact function from the NPC controller.
    public override void Interact()
    {
        QGS.OnInteract();

    }

//FUNCTION : AssignedQuest
//DESCRIPTION : Assigns the quest to the player if needed
//    void AssignQuest()
//    {
        
//        Quest = QuestList[i];
//        //checking to see if valid 
//        if (QM.searchCQNList(QuestList[i].Prereq1) && QM.searchCQNList(QuestList[i].Prereq2))
//        {
//            AssignedQuest = true;
//            Quest.Load();
//            Quest.StartText();
//        }
//        else
//           NoMoreQuest();
//    }

////FUNCTION : CheckQuest
////DESCRIPTION : Checking to see if quest is done or not and assigning the correct dialoge/action
//    void CheckQuest()
//    {
//        if(Quest.Completed)
//        {
//            Quest.GiveReward();
//            Helped = true;
//            AssignedQuest = false;
//            QM.addToCQNList(Quest.QuestName);
//            Quest.CompletedText();

//        }
//        else
//        {
//            Quest.InprogressText();
//        }
//    }

////FUNCTION : NextQuest
////DESCRIPTION : Calls the next quest in the line when the player revisits the questGiver
//    void NextQuest()
//    {
//        i++;
//        if (i >= QuestList.Count)
//        {
//            NoMoreQuest();
//        }
//        else
//        {
//            Helped = false;
//            AssignedQuest = false;
//            AssignQuest();

//        }
//    }

////FUNCTION : NoMoreQuest
////DESCRIPTION : Calls the dialog if no more quests are to be found
//    void NoMoreQuest()
//    {
//        if (QUIM)
//        {
//            QUIM.NPCBoxOne.text = "Welcome to Wonderland!";
//            QUIM.NPCBoxTwo.text = "No Available Quests";
//        }
//        Debug.Log("No Quest Got");
//    }

//FUNCTION : OnTriggerExit
//DESCRIPTION : closes UI when player is out of range
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            QuestGiverMenuOff();
        }
    }

}
