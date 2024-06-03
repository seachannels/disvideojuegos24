using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class titlescreen_clase : MonoBehaviour
{
    // Start is called before the first frame update
    enum SplashStates
    {
        title, //en modo press any button to start
        options, //en la pantalla de cargar partida
        credits,
    }
    SplashStates State;

    public GameObject options_screen;
    public GameObject title_screen;
    public GameObject credits;
    public GameObject loadingMessage;
    void Start()
    {
        State = SplashStates.title;
    }

    // Update is called once per frame
    void Update()
    {
        switch (State)
        {
            case SplashStates.title: //en el título
                //quitar botones
                options_screen.SetActive(false);
                credits.SetActive(false);
                //poner título
                title_screen.SetActive(true);
                //Evaluación de condiciones de cambio de estado
                if (Input.anyKeyDown)
                {
                    State = SplashStates.options;
                }
                break;

            case SplashStates.options: //en la pantalla de opciones

                //quitar título
                title_screen.SetActive(false);
                credits.SetActive(false);
                //poner botones
                options_screen.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit(); //cierra el juego
                }

                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))

                {
                    CameraFade.fadeScene = true;
                    Invoker.InvokeDelayed(empezar, 1);

                }
                break;

            case SplashStates.credits: //en la pantalla de opciones
                options_screen.SetActive(false);
                title_screen.SetActive(false);
                credits.SetActive(true);
                break;

        }
    }

    public void startGame()
    {
        CameraFade.fadeScene = true;
        Invoker.InvokeDelayed(empezar, 1);
    }
    public void creditsButton()
    {
        State = SplashStates.credits;

    }

    public void loadGame()
    {
        loadingMessage.SetActive(true);

        Invoker.InvokeDelayed(startGame, 2);
    }
    public void backOptions()
    {
        State = SplashStates.options;
    }

    public void cerrarJuego()
    {
        Application.Quit();
    }
    void empezar()
    {
        SceneManager.LoadSceneAsync(5); //carga el juego
    }
}