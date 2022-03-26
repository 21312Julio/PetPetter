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

    // get more coins every second depending on PPS level
    // update text mesh with amount of current currency and PPS and PPC level objects as well
    private void Update()
    {
        patCoin += patsPerSecond * Time.deltaTime;
        PatCoins.GetComponent<TMPro.TextMeshProUGUI>().text = "Pat Coins      P   " + ((int)patCoin).ToString();
        PPC.GetComponent<TMPro.TextMeshProUGUI>().text = patsPerClick.ToString();
        PPS.GetComponent<TMPro.TextMeshProUGUI>().text = patsPerSecond.ToString();
    }
    #endregion
}
