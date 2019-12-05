using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float movementX;
    public float speed = 15.0f;
    private bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        Flip(movementX);
    }

    void FixedUpdate() 
    {
        rigid.velocity = new Vector2 (movementX * speed, rigid.velocity.x);
    }

    private void Flip(float movementX)
    {
        if(movementX > 0 && !isFacingRight || movementX < 0 && isFacingRight)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }

    }
}