using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region FIELDS
    private Rigidbody2D rb;

    private float moveSpeed;
    private bool moveLeft, moveRight;
    #endregion

    #region METHODS

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

    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
    }

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
