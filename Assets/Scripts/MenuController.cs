using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Referencias a los Menus que se van a activar o desactivar
    public GameObject game;
    public GameObject aUpgrade;
    public GameObject cUpgrade;
    public GameObject options;

    // Start es llamado antes del primer frame
    void Start()
    {
        // Desactiva todos los paneles al comienzo, excepto el del juego
        game.SetActive(true);
        aUpgrade.SetActive(false);
        cUpgrade.SetActive(false);
        options.SetActive(false);
    }

    // Método que se llama cuando se hace clic en el botón del juego
    public void OnButton1Click()
    {
        // Desactiva los otros paneles y activa el juego
        game.SetActive(true);
        aUpgrade.SetActive(false);
        cUpgrade.SetActive(false);
        options.SetActive(false);
    }

    // Método que se llama cuando se hace clic en el botón de mojoras auto click
    public void OnButton2Click()
    {
        // Desactiva los otros paneles y activa el panel de mojoras auto click
        game.SetActive(false);
        aUpgrade.SetActive(true);
        cUpgrade.SetActive(false);
        options.SetActive(false);
    }

    // Método que se llama cuando se hace clic en el boton de mejoras de click
    public void OnButton3Click()
    {
        // Desactiva los otros paneles y activa el panel de mejoras de click
        game.SetActive(false);
        aUpgrade.SetActive(false);
        cUpgrade.SetActive(true);
        options.SetActive(false);
    }
    // Método que se llama cuando se hace clic en el boton de opciones
    public void OnButton4Click()
    {
        // Desactiva los otros paneles y activa el panel de opciones
        game.SetActive(false);
        aUpgrade.SetActive(false);
        cUpgrade.SetActive(false);
        options.SetActive(true);
    }
}
