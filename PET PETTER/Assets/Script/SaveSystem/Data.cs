using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    #region FIELDS
    [Header("Variables")]
    // Player and Pet
    public float level;
    public float currentExp;
    public float amountOfCoins;
    public float PPS;
    public float PPC;
    public string name;
    public string sprite;
    public string tile;
    // Shop Quantity
    public float conke;
    public float nanfa;
    public float zero;
    public float pramp;
    public float mtpoo;
    public float bepis;
    public float trooble;
    public float partey;
    public float patinator;
    #endregion

    #region METHODS

    // create a class of data to be save with binary formatter based on existing game objects
    // on scene, get their value and save to variables of class
    public Data(Player player, Pet pet, GameObject petSprite, GameObject tileSprite,
                BuyItem conkeGO, BuyItem nanfaGO, BuyItem zeroGO, BuyItem prampGO,
                BuyItem mtpooGO, BuyItem bepisGO, BuyUpgrade troobleGO, BuyUpgrade parteyGO,
                BuyUpgrade patinatorGO)
    {
        // Information
        level = pet.level;
        currentExp = pet.currentEXPats;
        amountOfCoins = player.patCoin;
        PPS = player.patsPerSecond;
        PPC = player.patsPerClick;
        name = pet.nameOfPet;
        sprite = petSprite.GetComponent<SpriteRenderer>().sprite.ToString();
        tile = tileSprite.GetComponent<SpriteRenderer>().sprite.ToString();
        // Store Amounts
        conke = conkeGO.amountOfItem;
        nanfa = nanfaGO.amountOfItem;
        zero = zeroGO.amountOfItem;
        pramp = prampGO.amountOfItem;
        mtpoo = mtpooGO.amountOfItem;
        bepis = bepisGO.amountOfItem;
        trooble = troobleGO.amountOfItem;
        partey = parteyGO.amountOfItem;
        patinator = patinatorGO.amountOfItem;
    }
    #endregion

}
