using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject savingMessage;
    public GameObject loadingMessage;
    public bool isPaused;
    // Start is called before the first frame update

    void Start()
    {
        pauseMenu.SetActive(false);
        savingMessage.SetActive(false);
        loadingMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resumeGame();
            }

            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void resumeGame()
    {
        loadingMessage.SetActive(false);
        savingMessage.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void saveGame()
    {
        savingMessage.SetActive(true);

        Invoker.InvokeDelayed(resumeGame, 2);
    }

    public void loadGame()
    {
        loadingMessage.SetActive(true);

        Invoker.InvokeDelayed(resumeGame, 2);
    }

    public void mainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
        isPaused = false;
    }

    public void quit()
    {
        Application.Quit();
    }

}
