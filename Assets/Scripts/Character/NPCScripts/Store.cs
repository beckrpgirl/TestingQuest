using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    //This script works by running into the vendors hitbox before you can purchase anything.
    //Steven and I have it working with a test scene where you can click on an object and it will
    //deduct coins and allow you to purchase items.
    Alison playerCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "Collectable":
                        int cost = hit.collider.gameObject.GetComponent<BaseCollectible>().Cost;

                        if (playerCharacter.GetCoin() <= cost)
                        {
                            print("You can't afford this");
                        }
                        else
                        {
                            print("Here you go");
                            playerCharacter.SetCoin(cost * -1);
                        }

                        
                        Debug.Log("Collectable clicked");
                        break;

                    default:
                        break;

                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerCharacter = other.gameObject.GetComponent<Alison>();
            print("hit");
            
        }
        
    }
}
