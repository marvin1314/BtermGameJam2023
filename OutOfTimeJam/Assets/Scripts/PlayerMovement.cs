using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int points;
    public Rigidbody2D rb;
    private float _MoveInputH;
    public Vector2 moveInput;
    public TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        // Handle player input here
        //moveInput.x = Input.GetAxisRaw("Horizontal"); // -1 for left, 1 for right, 0 for none
        _MoveInputH = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(_MoveInputH * (10), 0); // updates horizontal movement based on input
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
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<pointCollision>())
        {
            points += 1;
            score.text = "" + points;
        }
    }
}