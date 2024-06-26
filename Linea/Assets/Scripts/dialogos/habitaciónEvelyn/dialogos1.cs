using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogos1 : MonoBehaviour
{
    public enum ListaEscena
    {
        estado1,
        estado2,
        fin,
    }
    public ListaEscena estadoEscena;
    public GameObject dialogosUI;
    public enum listaDialogos
    {
        nada,
        dialogo0,
        dialogo1,
        dialogo2,
        dialogo3,
        dialogo4,
        dialogo5,
        dialogueEnd,
        FIN,
    }
    public static listaDialogos estadoDialogos;
    public GameObject dialogo0;
    public GameObject dialogo1;
    public GameObject dialogo2;
    public GameObject dialogo3;
    public GameObject dialogo4;
    public GameObject dialogo5;
    public GameObject figurinistaSprite;
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
                estadoDialogos = listaDialogos.dialogo0;
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
            case listaDialogos.nada:

                break;
            case listaDialogos.dialogo0:
                //Time.timeScale = 0f;

                dialogo0.SetActive(true);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                dialogo4.SetActive(false);
                dialogo5.SetActive(false);
                break;

            case listaDialogos.dialogo1:
                dialogo1.SetActive(true);
                dialogo0.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                dialogo4.SetActive(false);
                dialogo5.SetActive(false);
                break;

            case listaDialogos.dialogo2:
                dialogo2.SetActive(true);
                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo3.SetActive(false);
                dialogo4.SetActive(false);
                dialogo5.SetActive(false);
                break;

            case listaDialogos.dialogo3:

                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(true);
                dialogo4.SetActive(false);
                dialogo5.SetActive(false);
                break;
            case listaDialogos.dialogo4:
                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                dialogo4.SetActive(true);
                dialogo5.SetActive(false);
                figurinistaSprite.SetActive(true);
                break;
            case listaDialogos.dialogo5:

                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                dialogo3.SetActive(false);
                dialogo4.SetActive(false);
                dialogo5.SetActive(true);
                break;

            case listaDialogos.dialogueEnd:
                dialogosUI.SetActive(false);
                menuLibro.estadoTareas++;
                //Time.timeScale = 1f;
                estadoDialogos++;
                break;
            case listaDialogos.FIN:

                break;
        }
    }
}

