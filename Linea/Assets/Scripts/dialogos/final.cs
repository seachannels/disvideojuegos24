using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public enum listaDialogos
    {
        nada,
        dialogo0,
        dialogo1,
        dialogo2,
        FIN,
    }
    public GameObject dialogosUI;
    public listaDialogos estadoDialogos;
    public GameObject dialogo0;
    public GameObject dialogo1;
    public GameObject dialogo2;
    public GameObject playerPijama, playerVestido;
    public GameObject vestido;
    // Start is called before the first frame update
    void Start()
    {
        playerPijama.SetActive(true);
        playerVestido.SetActive(false);
        estadoDialogos = 0;
        //pijama=GetComponent<AnimatorController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estadoDialogos == listaDialogos.dialogo0)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
            {
                estadoDialogos++;
            }
        }
        switch (estadoDialogos)
        {
            case listaDialogos.nada:
                dialogosUI.SetActive(false);
                break;
            case listaDialogos.dialogo0:
                dialogosUI.SetActive(true);
                dialogo0.SetActive(true);
                dialogo1.SetActive(false);
                dialogo2.SetActive(false);
                break;

            case listaDialogos.dialogo1:
                playerVestido.SetActive(true);
                playerPijama.SetActive(false);
                dialogo1.SetActive(true);
                dialogo0.SetActive(false);
                dialogo2.SetActive(false);
                break;

            case listaDialogos.dialogo2:
                dialogo2.SetActive(true);
                dialogo0.SetActive(false);
                dialogo1.SetActive(false);
                break;

            case listaDialogos.FIN:
                dialogosUI.SetActive(false);

                break;
        }
    }

}

