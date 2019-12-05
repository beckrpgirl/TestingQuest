using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour
{
    public Alison alison;
    public Inventory inventory;
    public Item item;
    public int amount;
    public int duration;
    public int Cost;

    public abstract void ApplyEffect();
    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
        alison = FindObjectOfType<Alison>();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        inventory.Add(item);   // Add to inventory

        gameObject.SetActive(false);    // Destroy item from scene
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (inventory.items.Count >= inventory.space)
                Debug.Log("There is no room.");
            else
            {
                PickUp();
                gameObject.SetActive(false);
            }
        }
    }

}
