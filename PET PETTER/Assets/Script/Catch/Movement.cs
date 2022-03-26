using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region FIELDS
    [Header("Sprite")]
    private Rigidbody2D rb;
    [Header("Properties")]
    private float moveSpeed;
    private bool moveLeft, moveRight;
    #endregion

    #region METHODS

    // get elements and set state
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        moveLeft = false;
        moveRight = false;
    }

    public void MoveLeft()
    {
        moveLeft = true;
    }

    public void MoveRight()
    {
        moveRight = true;
    }

    // freeze character when movement isn't detected
    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
    }

    // define action and speed of sprite movement when touch is detected on buttons
    private void Update()
    {
        if (moveLeft)
        {
            rb.velocity = new Vector2(-moveSpeed, 0f);
        }
        if (moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, 0f);
        }
    }
    #endregion
}
