using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject xrayScreen;

    private void Start()
    {
        xrayScreen.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            xrayScreen.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            xrayScreen.SetActive(false);
        }

    }
}
