//FILE : IQuestID.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IQuestID
//PURPOSE : Information that the object needed for the quest gives into the quest system when either kill/collected or such

public interface IQuestID
{
    string ID { get; set; }
    int Experience { get; set; }
    int Coins { get; set; }


//FUNCTION : Cleared()
//DESCRIPTION : This function is called in the objects that are apart of quests, so we know if this is a part of the quest or not. 
//PARAMETERS : None
//RETURNS : None
    void Cleared();
}
