using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pet : MonoBehaviour
{
    #region FIELDS
    [Header("Pet Variables")]
    public float level = 1f;
    public string nameOfPet;
    public float requiredEXPats;
    public float currentEXPats;
    [Header("Colors")]
    Color yellow1;
    Color blue1;
    Color orange1;
    Color red1;
    Color green1;
    Color purple1;
    [Header("References")]
    public Player player;
    public GameObject LevelOfPet;
    public GameObject NameOfPet;
    public GameObject petSprite;
    public GameObject tileSprite;
    public Camera cam;
    public AudioSource squish;
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
    [Header("UI")]
    public Image xpBar;
    [Header("Multipliers")]
    [Range(1f, 300f)]
    public float additionMultiplier = 300;
    [Range(2f, 4f)]
    public float powerMultiplier = 2;
    [Range(7f, 14f)]
    public float divisionMultiplier = 7;
    #endregion

    #region METHODS

    // fill exp bar according to current exp, if pet doesn't already have a name (level 0)
    // randomize when the game is started, in case there isn't a save on binary formatter
    void Start()
    {
        xpBar.fillAmount = currentEXPats / requiredEXPats;
        requiredEXPats = CalculateRequiredExp();
        if (nameOfPet == "")
        {
            nameOfPet = RandomizeName();
        }
    }

    // constantly get EXP and coins every second depending on PPS level, update level of pet,
    // name and check for level to level up if exp is exceeded
    void Update()
    {
        GainExperience(player.patsPerSecond * Time.deltaTime);
        LevelOfPet.GetComponent<TMPro.TextMeshProUGUI>().text = level.ToString();
        NameOfPet.GetComponent<TMPro.TextMeshProUGUI>().text = nameOfPet;
        UpdateXPatsUI();
        if (currentEXPats > requiredEXPats)
        {
            LevelUp();
        }
    }

    // assign camera colors so that method can change every 10 levels using HEX systems
    void AssignColors()
    {
        ColorUtility.TryParseHtmlString("#E3DD4D", out yellow1);
        ColorUtility.TryParseHtmlString("#83DBE7", out blue1);
        ColorUtility.TryParseHtmlString("#E7B983", out orange1);
        ColorUtility.TryParseHtmlString("#DAA7A4", out red1);
        ColorUtility.TryParseHtmlString("#A1E5A0", out green1);
        ColorUtility.TryParseHtmlString("#9B8ADD", out purple1);
    }

    // get experience, used on tap method
    void GainExperience(float xpGained)
    {
        currentEXPats += xpGained;
    }

    // change sprites and names when you level up, increase level amount and reset expBar
    void LevelUp()
    {
        level++;
        xpBar.fillAmount = 0f;
        currentEXPats = Mathf.RoundToInt(currentEXPats - requiredEXPats);
        requiredEXPats = CalculateRequiredExp();
        Sprite[] petList = new Sprite[]{Dog, Bunny, Chicken, Duck, Frog, Piggy};
        Sprite[] tileList = new Sprite[]{Grass, Mud, Sand, Water};
        AssignColors();
        Color[] camColor = new Color[]{yellow1, blue1, orange1, red1, green1, purple1};

        if (level % 10 == 0)
        {
            int sprite = Random.Range(0, petList.Length);
            int tile = Random.Range(0, tileList.Length);
            int color = Random.Range(0, camColor.Length);
            nameOfPet = RandomizeName();
            petSprite.GetComponent<SpriteRenderer>().sprite = petList[sprite];
            tileSprite.GetComponent<SpriteRenderer>().sprite = tileList[tile];
            cam.GetComponent<Camera>().backgroundColor = camColor[color];
        }
    }

    // calculate required exp for the next level when you level up gradually
    private int CalculateRequiredExp()
    {
        int solveForRequiredXp = 0;
        for (int levelCycle = 1; levelCycle <= level; levelCycle++)
        {
            solveForRequiredXp += (int)Mathf.Floor(levelCycle + additionMultiplier * Mathf.Pow(powerMultiplier, levelCycle / divisionMultiplier));
        }
        return solveForRequiredXp / 4;
    }

    // update EXPBar, it's a fill image type
    void UpdateXPatsUI()
    {
        float xpFraction = currentEXPats / requiredEXPats;
        xpBar.fillAmount = xpFraction;
    }

    // get more coins and level depending on click level every tap, and play sound
    public void OnTap()
    {
        player.patCoin += player.patsPerClick;
        GainExperience(player.patsPerClick);
        squish.Play();
    }

    // generate a random name for the pet
    string RandomizeName()
    {
        string[] adjectives = new string[] { "Smol", "Snip Snap", "Big Ol", "Common", "Special", "Aquathicc", "Party Edition", "Heckin Angery", "Bamboozled", "Dangle", "Poodle", "Nakey", "Slithervester", "Comfy", "Blanket", "Limousine", "Four Footed", "Heb Hob", "Omnomnomnivore", "Heckin", "Dorito", "Itty Bitty", "Pocket", "Flying Parkour", "Teeny Tippy" };
        string[] firstNames = new string[] { "Yapper", "Floofer", "Grizlord", "Wrinkler", "Shoob", "Fangle", "Noodle", "Linguini", "Boi", "Gril", "Floofer", "Sammich", "Nope Rope", "Bob", "Rangle", "Whiffler", "Snapper", "Tapper", "Potato", "Cinnamon Roll", "Wannabe", "Raisin", "Jalapeno", "Creep Creep", "Shapeshifer", "Chomp Chomp" };
        string[] secondNames = new string[] { "The 1st", "The 2nd", "The 3rd", "The Unbeatten", "The Ultimate Champion", "The Eternal Bossom of Hot Love", "Wearing a Cape", "The biggest fool in history", "The helper of cows", "The unready", "The most huggable in all land", "With a peculiar nose", "With anxiety", "With wet socks", "Who loves pineapple on pizza" };
        // Get a random position of each array
        int index1 = Random.Range(0, adjectives.Length);
        int index2 = Random.Range(0, firstNames.Length);
        int index3 = Random.Range(0, secondNames.Length);
        // Return a value and join them together
        string fullName = adjectives[index1] + " " + firstNames[index2] + " " + secondNames[index3];
        return fullName;
    }
    #endregion

}
