using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireExtinguisher : MonoBehaviour
{
    public PlayerMovement movescript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            movescript.getExtinguisher = true;
            Destroy(gameObject);
        }
        
    }
}
