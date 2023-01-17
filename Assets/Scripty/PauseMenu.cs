using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvasObj;
    bool gamePaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            gamePaused = !gamePaused;
        if (gamePaused)
            canvasObj.SetActive(true);
        else
            canvasObj.SetActive(false);
    }
}
