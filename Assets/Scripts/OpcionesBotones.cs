using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesBotones: MonoBehaviour {
    //Botones
    public void Jugar()
    {
        SceneManager.LoadScene(2);
    }

    public void Seleccionar()
    {
        SceneManager.LoadScene(0);
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

    //Aqui añadimos los circuitos a elegir

    public void Circuito01()
    {
        SceneManager.LoadScene(2);
    }

    public void Circuito02()
    {
        SceneManager.LoadScene(3);
    }
}
