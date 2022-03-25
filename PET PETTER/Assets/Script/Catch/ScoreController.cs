using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    #region FIELDS
    public TextMeshProUGUI Score;
    public static int score;
    public static int winScore;
    public AudioSource drink;
    #endregion

    #region METHODS

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = score.ToString();
        winScore = score;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Salad")
        {
            SceneManager.LoadScene("Catch Lose");
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "Drink")
        {
            Destroy(target.gameObject);
            score++;
            drink.Play();
        }
    }
    #endregion
}
