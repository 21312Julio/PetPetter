using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    #region FIELDS
    [Header("Player Variables")]
    public float patsPerClick = 1f;
    public float patsPerSecond = 0f;
    public float patCoin = 0f;
    [Header("Object References")]
    public GameObject PPC;
    public GameObject PPS;
    public GameObject PatCoins;
    #endregion

    #region METHODS
    private void Start()
    {

    }

    private void Update()
    {
        patCoin += patsPerSecond * Time.deltaTime;
        PatCoins.GetComponent<TMPro.TextMeshProUGUI>().text = "Pat Coins      P   " + ((int)patCoin).ToString();
        PPC.GetComponent<TMPro.TextMeshProUGUI>().text = patsPerClick.ToString();
        PPS.GetComponent<TMPro.TextMeshProUGUI>().text = patsPerSecond.ToString();
    }
    #endregion
}
