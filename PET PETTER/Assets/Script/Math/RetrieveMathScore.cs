using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetrieveMathScore : MonoBehaviour
{
    #region FIELDS
    // score gameobject to be assigned with score amount
    public GameObject scoreText;
    public int highScore = 0;
    #endregion

    #region METHODS

    // retrieve score from previous scene by accessing another script's static var
    void Start()
    {
        Debug.Log(ClickAnswer.finalScore);
        highScore = ClickAnswer.finalScore;
        scoreText.GetComponent<TextMeshProUGUI>().text = ClickAnswer.finalScore.ToString();
    }
    #endregion
}
