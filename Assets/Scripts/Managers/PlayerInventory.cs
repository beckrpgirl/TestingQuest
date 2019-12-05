using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    private Alison alison;
    
    // Start is called before the first frame update

    void Start()
    {
         alison = FindObjectOfType<Alison>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateCoinCount();

    }

    void UpdateCoinCount()
    {
        if (alison && CoinText)
            CoinText.text = alison.GetCoin().ToString();
    }
}
