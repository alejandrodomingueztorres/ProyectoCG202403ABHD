using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Este m�todo se llama desde el bot�n para iniciar el juego
    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // M�todo para salir del juego
    public void salir()
    {
        Debug.Log("SALIR...");
        Application.Quit();
    }
}
