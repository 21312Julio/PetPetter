using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region FIELDS
    [Header("Object References")]
    public Player player;
    public Pet pet;
    public GameObject petSprite;
    public GameObject tileSprite;
    public BuyItem conke;
    public BuyItem nanfa;
    public BuyItem zero;
    public BuyItem pramp;
    public BuyItem mtpoo;
    public BuyItem bepis;
    public BuyUpgrade trooble;
    public BuyUpgrade partey;
    public BuyUpgrade patinator;
    public SpriteHandler sprite;
    [Header("Pet Sprites")]
    public Sprite Dog;
    public Sprite Bunny;
    public Sprite Chicken;
    public Sprite Duck;
    public Sprite Frog;
    public Sprite Piggy;
    [Header("Tile Sprites")]
    public Sprite Grass;
    public Sprite Mud;
    public Sprite Sand;
    public Sprite Water;
    #endregion

    #region METHODS

    // load the saved game data when you open the game by accessing the file saved and set
    // the game objects values to those in the file, change sprites according to string saved
    void Start()
    {
        Data playerData = SaveSystem.LoadPlayer();

        pet.level = playerData.level;
        pet.currentEXPats = playerData.currentExp;
        player.patCoin = playerData.amountOfCoins;
        player.patsPerClick = playerData.PPC;
        player.patsPerSecond = playerData.PPS;
        pet.nameOfPet = playerData.name;
        conke.amountOfItem = playerData.conke;
        nanfa.amountOfItem = playerData.nanfa;
        zero.amountOfItem = playerData.zero;
        pramp.amountOfItem = playerData.pramp;
        mtpoo.amountOfItem = playerData.mtpoo;
        bepis.amountOfItem = playerData.bepis;
        trooble.amountOfItem= playerData.trooble;
        partey.amountOfItem = playerData.partey;
        patinator.amountOfItem = playerData.patinator;
        sprite.sprite = playerData.sprite;
        sprite.tile = playerData.tile;

        if (playerData.sprite == "Dog 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Dog;
        }
        else if (playerData.sprite == "Bunny 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Bunny;
        }
        else if (playerData.sprite == "Chicken 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Chicken;
        }
        else if (playerData.sprite == "Duck 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Duck;
        }
        else if (playerData.sprite == "Frog 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Frog;
        }
        else if (playerData.sprite == "Piggy 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Piggy;
        }

        if (playerData.tile == "Grass Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Grass;
        }
        else if (playerData.tile == "Mud Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Mud;
        }
        else if (playerData.tile == "Sand Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Sand;
        }
        else if (playerData.tile == "Water Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Water;
        }


    }


    // constantly save and update data file information
    void Update()
    {
        SaveSystem.SavePlayer(player, pet, petSprite, tileSprite, conke, nanfa, zero, pramp, mtpoo,
            bepis, trooble, partey, patinator);
    }
    #endregion
}
