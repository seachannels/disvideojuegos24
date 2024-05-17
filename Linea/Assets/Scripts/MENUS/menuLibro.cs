using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLibro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bookMenu;
    public bool menuOpen;
    enum listaTareas
    {
        tarea0,
        tarea1,
        tarea2,
    }
    listaTareas estadoTareas;
    public GameObject tarea0;
    public GameObject tarea1;
    public GameObject tarea2;

    public GameObject seccionTareas;

    void Start()
    {
        bookMenu.SetActive(false);
        estadoTareas = listaTareas.tarea0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (menuOpen)
            {
                closeMenu();
            }

            else
            {
                openMenu();
            }

        }

        if (seccionTareas)
        {
            switch (estadoTareas)
            {
                case listaTareas.tarea0:
                    tarea0.SetActive(true);
                    tarea1.SetActive(false);
                    tarea2.SetActive(false);

                    break;

                case listaTareas.tarea1:
                    tarea1.SetActive(true);
                    tarea0.SetActive(false);
                    tarea2.SetActive(false);
                    break;

                case listaTareas.tarea2:
                    tarea2.SetActive(true); tarea0.SetActive(false);
                    tarea1.SetActive(false);
                    break;
            }
        }

    }
    public void openMenu()
    {
        bookMenu.SetActive(true);
        Time.timeScale = 0f;
        menuOpen = true;

    }

    public void closeMenu()
    {
        bookMenu.SetActive(false);
        Time.timeScale = 1f;
        menuOpen = false;
    }


    public void tareas()
    {
        seccionTareas.SetActive(true);



    }

}