//FILE : QuestManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 07/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestManager
//PURPOSE :Checks to see what Quests have been done and what quests can be unlocked because of the completed quests. 
public class QuestManager: MonoBehaviour
{
    public List<string> completedQuestNames;
    private bool isMatch = false;
    //FUNCTION : searchCGNList()
    //DESCRIPTION : Searchs the completed Quest Names list.
    //PARAMETERS : 
    //RETURNS : None()
    public void Awake()
    {
        addToCQNList("NULL");
        //completedQuestNames[0] = "NULL";
    }
    public bool searchCQNList(string name)
    {
        for (int i = 0; i < completedQuestNames.Count; i++)
        {
            if(name == completedQuestNames[i])
            {
                isMatch = true;
                break;
            }
            else
            {
                isMatch = false;
            }
        }
        return isMatch;
    }
    //FUNCTION : addCGNList()
    //DESCRIPTION : Adds to the completed Quest Names list.
    //PARAMETERS : 
    //RETURNS : None()
    public void addToCQNList(string addName)
    {
        completedQuestNames.Add(addName);
        Debug.Log(addName);
    }
}
