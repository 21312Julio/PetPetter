using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetrieveCoins : MonoBehaviour
{
    #region FIELDS
    public GameObject scoreText;
    #endregion

    #region METHODS
    void Start()
    {
       scoreText.GetComponent<TextMeshProUGUI>().text  = ScoreController.score.ToString();
    }
    #endregion
}
