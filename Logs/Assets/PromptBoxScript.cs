using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptBoxScript : MonoBehaviour
{
    public GameObject PromptBox;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Continue()
    {
        PromptBox.SetActive(false);
        Time.timeScale = 1f;
    }
}
