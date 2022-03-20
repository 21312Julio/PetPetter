using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyItem : MonoBehaviour
{
    #region FIELDS
    [Header("Object References")]
    public Player player;
    public Sprite buttonGreen;
    public Sprite buttonRed;
    public Button buyButton;
    public GameObject Price;
    public GameObject amount;
    [Header("Properties")]
    public float perSecond;
    public float price;
    public float amountOfItem;
    public float baseCost;
    #endregion

    #region METHODS
    private void Update()
    {
        UpdateButtonUI();
        amount.GetComponent<TMPro.TextMeshProUGUI>().text = amountOfItem.ToString();
        Price.GetComponent<TMPro.TextMeshProUGUI>().text = price.ToString();
    }

    void UpdateButtonUI()
    {
        if(player.patCoin > price)
        {
            buyButton.GetComponent<Image>().sprite = buttonGreen;
        }
        else
        {
            buyButton.GetComponent<Image>().sprite = buttonRed;
        }
    }

    public void Buy()
    {
        if (buyButton.image.sprite == buttonGreen)
        {
            player.patsPerSecond += perSecond;
            player.patCoin -= price;
            amountOfItem += 1;
            price = calculatePrice();
        }
    }

    int calculatePrice()
    {
        price += baseCost * Mathf.Pow(1.15f, amountOfItem);
        return (int)price;
    }
    #endregion
}
