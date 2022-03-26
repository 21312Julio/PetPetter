using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    #region METHODS
    // destroy elements when hit collider at the bottom of screen
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Drink" || target.tag == "Salad")
        {
            Destroy(target.gameObject);
        }
    }
    #endregion
}
