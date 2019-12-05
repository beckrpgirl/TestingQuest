using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//would like to also host the ability for the character to turn and face the NPC without moving towards them, and give a greeting
public abstract class NPCController : MonoBehaviour
{

    public GameObject QuestTextBox;
    public GameObject ShopTextBox;
    bool NPCClick = false;

    public Transform Alison;
    

    public abstract void Interact();

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
    void QuestGiverMenuOn()
    {
        QuestTextBox.SetActive(true);
        NPCClick = true;
        Interact();
    }
    public void QuestGiverMenuOff()
    {
        QuestTextBox.SetActive(false);
        NPCClick = false;
    }

    void InteractMouse()
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
                            QuestGiverMenuOn();
                        else
                            QuestGiverMenuOff();
                        //Debug.Log("Quest giver clicked");
                        break;
                    case "NPCTalk":
                        if (!NPCClick)
                            ShopGiverMenuOn();
                        else
                            ShopGiverMenuOff();
                        //Debug.Log("Quest giver clicked");
                        break;
                    default:
                        break;

                }
            }

        }

    }

    //void OnTriggerExit(Collider other)
    //{
    //    if(other.gameObject.tag == "Player")
    //    {
            
    //        //ShopGiverMenuOff();
    //        QuestGiverMenuOff();
    //    }
    //}

    void ShopGiverMenuOn()
    {
        ShopTextBox.SetActive(true);
        NPCClick = true;
        Interact();
    }
    public void ShopGiverMenuOff()
    {
        ShopTextBox.SetActive(false);
        NPCClick = false;
    }


    public void LookAt()
    {
        transform.LookAt(Alison);
    }
}
