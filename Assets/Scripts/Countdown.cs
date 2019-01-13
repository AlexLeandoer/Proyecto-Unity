using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CuentaAtras;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public AudioSource Musica;

    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CuentaAtras.GetComponent<Text>().text = "3";
        GetReady.Play();
        CuentaAtras.SetActive(true);
        yield return new WaitForSeconds(1);
        CuentaAtras.SetActive(false);
        CuentaAtras.GetComponent<Text>().text = "2";
        GetReady.Play();
        CuentaAtras.SetActive(true);
        yield return new WaitForSeconds(1);
        CuentaAtras.SetActive(false);
        CuentaAtras.GetComponent<Text>().text = "1";
        GetReady.Play();
        CuentaAtras.SetActive(true);
        yield return new WaitForSeconds(1);
        CuentaAtras.SetActive(false);
        GoAudio.Play();
        Musica.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);

    }

}
