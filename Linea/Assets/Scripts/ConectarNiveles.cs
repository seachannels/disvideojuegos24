using UnityEngine;

[CreateAssetMenu(menuName = "Niveles/Conexiones")]

public class ConectarNiveles : ScriptableObject
{
   public static ConectarNiveles ActiveConnection { get; set;}
}
