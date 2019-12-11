//FILE : QuestGiver.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestGiver
//PURPOSE : Controls the handing out and dialog of the character. 
public class QuestGiver1 : NPCController
{
    //UI and Quests.cs to link to
    //QuestUIManager QUIM;
    //QuestManager QM;
    BobNPC BNPC;

    //public Quests Quest { get; set; }
    //public bool AssignedQuest { get; set; } //Has quest been assigned
    //public bool Helped { get; set; } //quest to hand in
    //public List<Quests> QuestList = new List<Quests>(); //List of quests for NPC
    //int i = 0; //quest counter


    void Awake()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //QM = FindObjectOfType<QuestManager>();
        BNPC = GetComponent<BobNPC>();
    }
    //Interact function from the NPC controller.
    public override void Interact()
    {
        BNPC.OnInteract();
        Debug.Log(tag);
    }
    public override void InteractMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "QuestGiver2":
                        if (!NPCClick)
                        { 
                            QuestGiverMenuOn();
                        }
                        else
                        {
                            QuestGiverMenuOff();
                        }
                           
                        break;
                    default:
                        break;

                }
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            QuestGiverMenuOff();
        }
    }

}
