using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    [SerializeField]
    private ConectarNiveles _conexiones;

    [SerializeField]
    private int _targetSceneIndex;

    [SerializeField]
    private Transform _spawnPoint;

    [SerializeField]
    private bool _requireKeyInput = false;
    [SerializeField]
    private KeyCode _inputKey = KeyCode.E; // Puedes cambiar la tecla según necesites

    private bool _playerInRange = false;

 private void Update()
    {
        if (_playerInRange && _requireKeyInput && Input.GetKeyDown(_inputKey))
        {
            ConectarNiveles.ActiveConnection = _conexiones;
        SceneManager.LoadScene(_targetSceneIndex);
        }
    }

    private void Start (){
        if (_conexiones == ConectarNiveles.ActiveConnection){
            FindObjectOfType<Player>().transform.position = _spawnPoint.position;
        }
    }
    /*private void OnCollisionEnter2D(Collision2D other){
        var player = other.collider.GetComponent<Player>();
        if (player != null) {
        ConectarNiveles.ActiveConnection = _conexiones;
        SceneManager.LoadScene(_targetSceneIndex);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D other){
    var player = other.GetComponent<Player>();
    if (player != null) {
         _playerInRange = true;
            if (!_requireKeyInput){
        ConectarNiveles.ActiveConnection = _conexiones;
        SceneManager.LoadScene(_targetSceneIndex);
        }
    }
}
}