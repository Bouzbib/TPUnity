using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSwitcher : MonoBehaviour
{
    public int sceneNumber = 0;

    public void GoToLevel1()
    {
        SceneManager.LoadScene("SampleScene");
        sceneNumber = 0;
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("SampleScene2");
    }


	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (sceneNumber == 1)
        {
            GoToLevel1();
        }

        if (sceneNumber == 2)
        {
            SceneManager.LoadScene("/Jeu_level2/scene");
            sceneNumber = 0;

        }

        if (sceneNumber == 3)
        {
            SceneManager.LoadScene("Motor_Level3");
            sceneNumber = 0;

        }
    }
}
