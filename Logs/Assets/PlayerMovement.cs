using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float movementX;
    public float speed = 100;
    private bool isFacingRight = true;
    public bool getExtinguisher = false;
    public GameObject extinguisherSprite;
    public AudioSource extinguish;
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
        extinguisherSprite.SetActive(false);

        if (extinguish == null)
        {
            extinguish = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        if (getExtinguisher==true)
        {
            extinguisherSprite.SetActive(true);
        }
        
        if (getExtinguisher && Input.GetKeyDown("f"))
        {
            Shoot();
        }
    }

    void FixedUpdate() 
    {
        rigid.velocity = new Vector2 (movementX * speed, rigid.velocity.y);
        if (movementX > 0 && !isFacingRight || movementX < 0 && isFacingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
        isFacingRight = !isFacingRight;
    }

    void Shoot()
    {
        var clonePrefab = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Destroy(clonePrefab, 5);
    }


}