using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : BaseCollectible, IQuestID
{
    public string ID { get; set; }
    public int Experience { get; set; }
    public int Coins { get; set; }

    void Awake()
    {
        ID = "wood";
        Experience = 0;
        Coins = 10;
    }
    public override void ApplyEffect()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        alison = other.GetComponent<Alison>();

        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Done();
        }
        this.Invoke("reset", duration);

    }

    void reset()
    {
        gameObject.SetActive(true);
    }
    public void Done()
    {
        QuestEvents.EnemyDied(this);
    }
   
}
