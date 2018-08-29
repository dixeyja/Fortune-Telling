using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject menu;

    private void OnMouseDown()
    {
        if (gameObject.name == "UnPause")
            UnPause();
        else if (gameObject.name == "Restart")
            Restart();
        else if (gameObject.name == "Quit")
            QuitGame();
    }

    public void UnPause()
    {
        menu.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
