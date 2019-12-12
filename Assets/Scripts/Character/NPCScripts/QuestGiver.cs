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

    DoozyNPC DNPC;

    void Awake()
    {

        DNPC = GetComponent<DoozyNPC>();
    }
    //Interact function from the NPC controller.
    public override void Interact()
    {
        DNPC.OnInteract();
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
                    case "QuestGiver":
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
