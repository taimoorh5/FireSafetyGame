using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 200f;
    public bool isFacingRight = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementX = Input.GetAxis("Horizontal");
        if(movementX < 0) GetComponent<Rigidbody2D>().velocity = new Vector3(movementX * speed, GetComponent<Rigidbody2D>().velocity.y);
        if(movementX > 0) GetComponent<Rigidbody2D>().velocity = new Vector3(movementX * speed, GetComponent<Rigidbody2D>().velocity.y);

        if(movementX < 0 && isFacingRight) Flip();
        if(movementX > 0 && !isFacingRight) Flip();
        
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(Vector3.up * 180);
    }
}