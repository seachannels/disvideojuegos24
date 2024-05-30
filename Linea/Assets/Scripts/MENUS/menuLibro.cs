using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLibro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bookMenu;
    public bool menuOpen;
    public enum listaTareas
    {
        tarea0,
        tarea1,
        tarea2,
        tarea3,
    }
    public static listaTareas estadoTareas;

    public GameObject tarea0;
    public GameObject tarea1;
    public GameObject tarea2;
    public GameObject tarea3;
    private enum listaPaginas
    {
        pag1,
        pag2,
        pag3,
        pag4,
        pag5,
    }
    private listaPaginas paginaLibro;
    public GameObject seccionTareas, seccionLog, seccionInventario, seccionPersonajes, seccionMapa;

    void Start()
    {
        bookMenu.SetActive(false);
        estadoTareas = 0;
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
        switch (paginaLibro)
        {
            case listaPaginas.pag1:
                tareas();
                break;
            case listaPaginas.pag2:
                inventario();
                break;
            case listaPaginas.pag3:
                mapa();
                break;
            case listaPaginas.pag4:
                log();
                break;
            case listaPaginas.pag5:
                personajes();
                break;
        }
        switch (estadoTareas)
        {
            case listaTareas.tarea0:
                tarea0.SetActive(true);
                tarea1.SetActive(false);
                tarea2.SetActive(false);
                tarea3.SetActive(false);

                break;

            case listaTareas.tarea1:
                tarea0.SetActive(false);
                tarea1.SetActive(true);
                tarea2.SetActive(false);
                tarea3.SetActive(false);

                break;

            case listaTareas.tarea2:
                tarea0.SetActive(false);
                tarea1.SetActive(false);
                tarea2.SetActive(true);
                tarea3.SetActive(false);
                break;
            case listaTareas.tarea3:
                tarea0.SetActive(false);
                tarea1.SetActive(false);
                tarea2.SetActive(false);
                tarea3.SetActive(true);

                break;
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

  /*  public void nextPage()
    {
        if (paginaLibro is not listaPaginas.pag5)
        {
            paginaLibro++;
        }
        else {paginaLibro = listaPaginas.pag1; }
    }*/

    public void tareas()
    {
        seccionTareas.SetActive(true);
        seccionLog.SetActive(false);
        seccionInventario.SetActive(false);
        seccionPersonajes.SetActive(false);
        seccionMapa.SetActive(false);
    }

    public void log()
    {
        seccionTareas.SetActive(false);
        seccionLog.SetActive(true);
        seccionInventario.SetActive(false);
        seccionPersonajes.SetActive(false);
        seccionMapa.SetActive(false);
    }

    public void inventario()
    {
        seccionTareas.SetActive(false);
        seccionLog.SetActive(false);
        seccionInventario.SetActive(true);
        seccionPersonajes.SetActive(false);
        seccionMapa.SetActive(false);
    }

    public void personajes()
    {
        print("personajes");
        seccionTareas.SetActive(false);
        seccionLog.SetActive(false);
        seccionInventario.SetActive(false);
        seccionPersonajes.SetActive(true);
        seccionMapa.SetActive(false);
    }

    public void mapa()
    {
        seccionTareas.SetActive(false);
        seccionLog.SetActive(false);
        seccionInventario.SetActive(false);
        seccionPersonajes.SetActive(false);
        seccionMapa.SetActive(true);
    }

}