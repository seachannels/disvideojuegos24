using UnityEngine;
using UnityEngine.SceneManagement;

public class Titulo : MonoBehaviour
{
   // public GameObject playOptionsScreen;

    void Update()
    {
        // Verifica si se presiona cualquier tecla o botón del ratón para avanzar a la pantalla de juego
        if (Input.anyKeyDown)
        {
            // Activa la pantalla de juego con los botones de play y opciones
           // playOptionsScreen.SetActive(true);
            // Desactiva esta pantalla de título
            gameObject.SetActive(false);
        }
    }
}