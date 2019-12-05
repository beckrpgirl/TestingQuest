using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShopUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI NPCBoxOne;
    public GameObject ToggleButtonA;
    public GameObject ToggleButtonB;

    public GameObject Potion1Button;
    public TextMeshProUGUI Potion1Text;
    public GameObject Potion2Button;
    public TextMeshProUGUI Potion2Text;
    public GameObject Potion3Button;
    public TextMeshProUGUI Potion3Text;
    public GameObject ExitButton;
    public TextMeshProUGUI ExitText;



    bool toggle = true;
    ShopNPC shopNPC;

    void Start()
    {
        shopNPC = FindObjectOfType<ShopNPC>();
        StartText();
    }

    void StartText()
    {
        Welcome();
        //PotionLables();
    }

    void PotionLables()
    {
        if (shopNPC)
        {
            Potion1Text.text = "Punishment Punch 10";

            Potion2Text.text = "Swift Soda 15";

            Potion3Text.text = "Replenish Remedy 20";

            ExitText.text = "Exit";
        }
    }
    void Welcome()
    {
        if (shopNPC)
        {
            NPCBoxOne.text = "Welcome to my humble shop Alison.";
        }
        //add other responces to welcomes if needed. 
    }

    public void buying()
    {
        if (shopNPC)
        {
            NPCBoxOne.text = "I do hope you enjoy that potion.";
        }
    }

    public void NoFunds()
    {
        if (shopNPC)
        {
            NPCBoxOne.text = "You don't seem to have enough coin for that item.";
        }
    }

    void Goodbye()
    {
        if (shopNPC)
        {
            NPCBoxOne.text = "Thank you, come again!";
        }
    }
    
    public void ShopToggleMenu()
    {
        if (!toggle)
        {
            ToggleButtonA.SetActive(true);
            ToggleButtonB.SetActive(true);
            toggle = true;
        }
        else if (toggle)
        {
            ToggleButtonA.SetActive(false);
            ToggleButtonB.SetActive(false);
            toggle = false;
        }
    }

}
