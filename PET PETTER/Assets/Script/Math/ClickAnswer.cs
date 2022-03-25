using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ClickAnswer : MonoBehaviour
{
    #region FIELDS
    [Header("Object References")]
    public TextMeshProUGUI number;
    public AudioSource corSE;
    public MathMinigameRandom mathMinigame;
    public TextMeshProUGUI scoreText;
    [Header("Variables")]
    public static int finalScore;
    public static int score;

    #endregion

    #region METHODS
    private void Update()
    {
        scoreText.text = score.ToString();
        finalScore = score;
    }

    public void ClickNumber()
    {
        if (number.text == mathMinigame.result.ToString())
        {
            Debug.Log("Correct!");
            score += 1;
            corSE.Play();
            MathMinigameRandom.secondsLeft += 5;
            Debug.Log(score);
            mathMinigame.GetRandomNumber();
            mathMinigame.GetRandomOptions();
            mathMinigame.AssignOptions();
        }
        else
        {
            Debug.Log("Wrong");
            SceneManager.LoadScene("Math Lose");
        }
    }
    #endregion
}
