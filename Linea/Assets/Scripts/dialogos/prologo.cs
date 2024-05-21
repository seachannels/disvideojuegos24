using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prologo : MonoBehaviour
{
    public enum ListaEscena
    {
        estado1,
        estado2,
        fin,
    }
    public ListaEscena estadoEscena;
    public enum listaDialogos
    {
        dialogo0,
        dialogo1,
        dialogo2,
        dialogo3,
        pasarEsc,
        FIN,
    }
    public listaDialogos estadoDialogos;
    public GameObject dialogo0;
    public GameObject dialogo1;
    public GameObject dialogo2;
    public GameObject dialogo3;
    // Start is called before the first frame update
    void Start()
    {
        estadoDialogos = 0;
        estadoEscena = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (estadoEscena)
        {
            case ListaEscena.estado1:
                CameraFade.fadeScene = true;
                estadoEscena++;
                break;
            case ListaEscena.estado2:
                CameraFade.fadeScene = false;
                estadoEscena++;
                break;
            case ListaEscena.fin:
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            estadoDialogos++;
        }
        switch (estadoDialogos)
        {
            case listaDialogos.dialogo0:
                dialogo0.SetActive(true);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                break;

            case listaDialogos.dialogo1:
                dialogo1.SetActive(true);
                dialogo0.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                break;

            case listaDialogos.dialogo2:
                dialogo2.SetActive(true);
                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo3.SetActive(false);
                break;

            case listaDialogos.dialogo3:
                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(true);
                break;

            case listaDialogos.pasarEsc:
                CameraFade.fadeScene = true;
                Invoker.InvokeDelayed(CargarEscena1, 1);
                estadoDialogos++;
                break;
            case listaDialogos.FIN:

                break;
        }
    }

    void CargarEscena1()
    {
        SceneManager.LoadSceneAsync(1); //carga el juego
    }
}

