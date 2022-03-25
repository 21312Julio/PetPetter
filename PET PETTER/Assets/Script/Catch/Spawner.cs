using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region FIELDS
    public GameObject[] drinks;
    public GameObject salad;

    public float xBounds, yBounds;
    #endregion

    #region METHODS
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomDrink = Random.Range(0, drinks.Length);

        if(Random.value <= .6f)
        {
            Instantiate(drinks[randomDrink],
                new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }
        else
        {
            Instantiate(salad,
                new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomGameObject());
    }
    #endregion
}
