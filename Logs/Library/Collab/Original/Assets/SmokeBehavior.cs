using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeBehavior : MonoBehaviour
{
    public bool inRadius = false;
    public GameObject promptBox;
    public bool isDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && inRadius)
        {
            Destroy(gameObject, 2);
            isDestroyed = true;
        }

        if (isDestroyed == true)
        {
            promptBox.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("player nearby");
            inRadius = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("user out of range");
        inRadius = false;
    }

    public void Continue ()
    {
        promptBox.SetActive(false);
        Time.timeScale = 1f;
    }
}
