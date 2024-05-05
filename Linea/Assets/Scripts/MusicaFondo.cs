using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    // Variable estática para almacenar la instancia del objeto de audio
    private static MusicaFondo instance;

    // Método que se ejecuta antes de Start()
    private void Awake()
    {
        // Si no hay otra instancia de este objeto de audio
        if (instance == null)
        {
            // Se marca este objeto como la instancia
            instance = this;
            // No se destruye este objeto cuando se cambia de escena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, se destruye este objeto para evitar duplicados
            Destroy(gameObject);
        }
    }
}