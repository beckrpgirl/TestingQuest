using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestID
{
    string ID { get; set; }
    int Experience { get; set; }
    int Coins { get; set; }

    void Done();
}
