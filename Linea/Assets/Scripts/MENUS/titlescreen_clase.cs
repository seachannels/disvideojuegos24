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
    }
    SplashStates State;

    public GameObject options_screen;
    public GameObject title_screen;
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

                //poner botones
                options_screen.SetActive(true);

                if (Input.GetKey(KeyCode.Escape))
                {
                    Application.Quit(); //cierra el juego
                }

                if (Input.GetKey(KeyCode.Return)) //tiene que funcionar con enter pero esto inicializa como muy rápido
                {
                    SceneManager.LoadSceneAsync(1); //carga el juego
                }
                break;
        }
    }
}