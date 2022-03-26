using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // drinks array with presets, salad object and screen bounds that can be adjusted
    #region FIELDS
    public GameObject[] drinks;
    public GameObject salad;

    public float xBounds, yBounds;
    #endregion

    #region METHODS

    // start the spawn method coroutine
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    // spawn preset objects within the given range on screen and time range
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
