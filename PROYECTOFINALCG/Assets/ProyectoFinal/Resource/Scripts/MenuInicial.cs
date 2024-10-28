using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Este método se llama desde el botón para iniciar el juego
    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Método para salir del juego
    public void salir()
    {
        Debug.Log("SALIR...");
        Application.Quit();
    }
}
