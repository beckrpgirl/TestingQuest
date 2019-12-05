using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class NewBehaviourScript : Alison
{
    int PlayerCoins;
    int isSwiftSodaIsSold;
    int isReplenishRemedyIsSold;
    int isPunishmentPunchIsSold;

    public Text coinAmountText;
    public Text SwiftPrice;
    public Text ReplenishPrice;
    public Text PunishPrice;

    public Button buyButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinAmountText.text = "COINS: " + PlayerCoins.ToString();
        isSwiftSodaIsSold = PlayerPrefs.GetInt("IsReplenishRemedySold");

        //if (PlayerCoins >= && isSwiftSodaIsSold == 0)
        //    buyButton.interactable = true;
        //else
        //    buyButton.interactable = false;
    }

    void buyRemedy()
    {
        PlayerCoins -= 5;
            PlayerPrefs.SetInt("isReplenishRemedySOld", 1);
            ReplenishPrice.text = "Sold!";
            buyButton.gameObject.SetActive(false);
    }
    void exitShop()
    {
            PlayerPrefs.SetInt("PlayerCoins", PlayerCoins);
            //Load whatever scene we want here: SceneManager.LoadScene ("GameScene")

    }

    //void resetPlayerPrefs()
    //{
    //    PlayerCoins = amount;
    //    buyButton.gameObject.SetActive(true);
    //}

}
