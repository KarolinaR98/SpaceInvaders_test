using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonsNav : MonoBehaviour
{
    public void LoadRoom(string levelName)
    {
        SceneManager.LoadScene(levelName);
        if (levelName == "Game")
        {
            GameManager.playGame = true;
            GameManager.isInStatistic = false;
        }
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
