﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//would like to also host the ability for the character to turn and face the NPC without moving towards them, and give a greeting
public abstract class NPCController : MonoBehaviour
{

    public GameObject NPC_UI;
    public bool NPCClick = false;
    public string NPCID;

    public Transform Alison;
    

    public abstract void Interact();
    public abstract void InteractMouse();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InteractMouse();
        LookAt();
    }

    //Interactions with NPC
    public void QuestGiverMenuOn()
    {
        NPC_UI.SetActive(true);
        NPCClick = true;
        Interact();
    }
    public void QuestGiverMenuOff()
    {
        NPC_UI.SetActive(false);
        NPCClick = false;
    }



    public void LookAt()
    {
        transform.LookAt(Alison);
    }
}
