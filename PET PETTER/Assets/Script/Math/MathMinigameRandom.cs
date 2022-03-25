using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MathMinigameRandom : MonoBehaviour
{
    #region FIELDS
    [Header("Variables")]
    // Equation numbers
    private int numberOne;
    private int numberTwo;
    public int result;
    [Header("Object References")]
    // Equation numbers text
    public GameObject firstText;
    public GameObject secondText;
    public GameObject thirdText;
    public GameObject timerDisplay;
    // Options array
    public TextMeshProUGUI optionOne;
    public TextMeshProUGUI optionTwo;
    public TextMeshProUGUI optionThree;
    public TextMeshProUGUI optionFour;
    // Equation options value
    private List<int> numbers;
    // Variables
    public static int secondsLeft;
    public bool takingAway = false;


    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
        secondsLeft = 30;
        ClickAnswer.score = 0;
        GetRandomNumber();
        GetRandomOptions();
        AssignOptions();
    }

    private void Update()
    {
        timerDisplay.GetComponent<TextMeshProUGUI>().text = "00: " + secondsLeft;
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (secondsLeft == 0)
        {
            SceneManager.LoadScene("Math Lose");
        }
    }

    public void GetRandomNumber()
    {
        numberOne = Random.Range(5, 16);
        numberTwo = Random.Range(6,17);
        result = numberOne * numberTwo;
        firstText.GetComponent<TextMeshProUGUI>().text = numberOne.ToString();
        secondText.GetComponent<TextMeshProUGUI>().text = numberTwo.ToString();
        thirdText.GetComponent<TextMeshProUGUI>().text = result.ToString();
    }

    public void GetRandomOptions()
    {
        numbers = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            int random = Random.Range(result+1, result+20);
            while (numbers.Contains(random))
            {
                random = Random.Range(result+1, result+20);
            }
            numbers.Add(random);
        }
        numbers.Add(result);
    }

    public void AssignOptions()
    {
        int randomPosition = 0;
        List<int> usedPositions = new List<int>();
        TextMeshProUGUI[] options = new TextMeshProUGUI[]{optionOne, optionTwo, optionThree, optionFour};
        for(int i = 0; i < 4; i++)
        {
            randomPosition = Random.Range(0, options.Length);
            while (usedPositions.Contains(randomPosition))
            {
                randomPosition = Random.Range(0, options.Length);
            }
            usedPositions.Add(randomPosition);
            options[randomPosition].text = numbers[i].ToString();
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        timerDisplay.GetComponent<TextMeshProUGUI>().text = "00: " + secondsLeft;
        takingAway = false;
    }
    #endregion
}
