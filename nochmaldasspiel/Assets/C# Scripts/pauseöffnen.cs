using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseöffnen : MonoBehaviour
{

    public static bool pause = false;

    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        //pauseMenuUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (pause) {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
        
    }
}

