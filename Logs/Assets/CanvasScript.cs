using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public GameObject textCanvas; // Assign in inspector
    private bool isShowing;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")) 
        {
            isShowing = !isShowing;
            textCanvas.SetActive(isShowing);
        }
    }
}