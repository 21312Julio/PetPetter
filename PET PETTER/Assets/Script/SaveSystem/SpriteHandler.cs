using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHandler : MonoBehaviour
{
    #region FIELDS
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
    [Header("Variables")]
    public string sprite;
    public string tile;
    [Header("Object References")]
    public GameObject petSprite;
    public GameObject tileSprite;
    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
    }

    // depending on the string that is retrieved on the load method, change the current sprites on screen
    // to match the ones saved at the time
    void ChangePetSprite()
    {
        if (sprite == "Dog 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Dog;
        }
        else if (sprite == "Bunny 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Bunny;
        }
        else if (sprite == "Chicken 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Chicken;
        }
        else if (sprite == "Duck 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Duck;
        }
        else if (sprite == "Frog 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Frog;
        }
        else if (sprite == "Piggy 1 (UnityEngine.Sprite)")
        {
            petSprite.GetComponent<SpriteRenderer>().sprite = Piggy;
        }
    }

    void ChangeTileSprite()
    {
        if (tile == "Grass Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Grass;
        }
        else if (tile == "Mud Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Mud;
        }
        else if (tile == "Sand Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Sand;
        }
        else if (tile == "Water Tile (UnityEngine.Sprite)")
        {
            tileSprite.GetComponent<SpriteRenderer>().sprite = Water;
        }
    }
    #endregion
}
