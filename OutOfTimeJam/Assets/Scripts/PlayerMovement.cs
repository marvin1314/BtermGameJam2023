using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Vector2 moveInput;

    // Update is called once per frame
    void Update()
    {
        // Handle player input here
        moveInput.x = Input.GetAxisRaw("Horizontal"); // -1 for left, 1 for right, 0 for none
    }

    void FixedUpdate()
    {
        // Handle movement here
        Vector2 targetMovePosition = rb.position + moveInput.normalized * moveSpeed * Time.fixedDeltaTime;

        RaycastHit2D raycastHit = Physics2D.Raycast(rb.position, moveInput.normalized, moveSpeed * Time.fixedDeltaTime);

        if (raycastHit.collider == null)
        {
            //if you don't hit anything move normally
            rb.MovePosition(targetMovePosition);
        }
        else
        {
            //do nothing
        }

    }
}