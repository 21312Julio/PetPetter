using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetrieveMathScore : MonoBehaviour
{
    #region FIELDS
    public GameObject scoreText;
    #endregion

    #region METHODS
    void Start()
    {
        Debug.Log(ClickAnswer.finalScore);
        scoreText.GetComponent<TextMeshProUGUI>().text = ClickAnswer.finalScore.ToString();
    }
    #endregion
}
