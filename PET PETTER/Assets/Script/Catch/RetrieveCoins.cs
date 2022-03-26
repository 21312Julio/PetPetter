using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetrieveCoins : MonoBehaviour
{
    // scoreText TextMeshProGUI to display amount
    #region FIELDS
    public GameObject scoreText;
    public int highScore;
    #endregion

    #region METHODS
    // access variable from ScoreController in another scene to get the score and display on screen
    void Start()
    {
        highScore = ScoreController.score;
       scoreText.GetComponent<TextMeshProUGUI>().text  = ScoreController.score.ToString();
    }
    #endregion
}
