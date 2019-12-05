using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EscortChar : NPCController, IQuestID
{

    private NavMeshAgent agent;
    public int followRange = 5;
    public bool Finished = true;
    public string ID { get; set; }
    public int Experience { get; set; }
    public int Coins { get; set; }

    protected Animator billyAnim;
    public bool Found;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        ID = "BillyBob";
        billyAnim = GetComponent<Animator>();
        Finished = true;
        Found = false;
    }
    private void FixedUpdate()
    {
        if(Finished==false)
        {
            FollowPlayer();
            Found = true;
        }
        

    }

    void FollowPlayer()
    {
        if ((Alison.transform.position - transform.position).magnitude <= followRange)
        {
           agent.SetDestination(Alison.transform.position + new Vector3(0, 0, 1));
           if(billyAnim)
               billyAnim.SetLayerWeight(1, 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Home")
        {
            Done();
            Finished = true;
        }
    }



    public override void Interact()
    {

    }

    public void Done()
    {
        QuestEvents.EnemyDied(this);
    }

}
