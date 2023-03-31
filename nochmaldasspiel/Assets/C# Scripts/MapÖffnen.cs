using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map÷ffnen : MonoBehaviour
{
    private bool isCameraZoomedOut = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isCameraZoomedOut)
            {
                Camera.main.orthographicSize = 5;
                isCameraZoomedOut = false;
            }
            else
            {
                Camera.main.orthographicSize = 37;
                isCameraZoomedOut = true;
            }
        }
    }
}
