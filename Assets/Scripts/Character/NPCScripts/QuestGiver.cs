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
   
    QuestGiverScript QGS;

    void Awake()
    {
        QGS = GetComponent<QuestGiverScript>();
        NPCID = gameObject.name;
        Debug.Log(NPCID);
    }
    //Interact function from the NPC controller.
    public override void Interact()
    {
        QGS.OnInteract();
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
                if (NPCID == hit.collider.name)
                {
                    if (!NPCClick)
                    {
                        QuestGiverMenuOn();
                    }
                    else
                    {
                        QuestGiverMenuOff();
                    }
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
