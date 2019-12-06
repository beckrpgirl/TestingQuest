//FILE : KillableQuest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class KillableQuest : ScriptableObject
{

    public string title = "Quest Name";    // Name of Quest




    public Sprite icon = null;              // Item icon
    public bool showInInventory = true;
    Inventory inventory;
    public Alison alison;
    public int ItemCost;
    // Called when the item is pressed in the inventory
    public void Start()
    {
        //inventory = FindObjectOfType<Inventory>();
    }

    public virtual void Use()
    {
        // Use the item

    }


}