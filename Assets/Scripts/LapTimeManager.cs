using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public static int minutos;
    public static int segundos;
    public static float mili;
    public static string milidisplay;

    public GameObject cajaMinutos;
    public GameObject cajaSegundos;
    public GameObject cajaMili;

	// Se actualiza por cada frame
    // Cambio los minutos segundos y milesimas de la inferfaz
	void Update () {
        mili += Time.deltaTime * 10;
        milidisplay = mili.ToString("F0");
        cajaMili.GetComponent<Text>().text = "" + milidisplay;

        if(mili >= 10)
        {
            mili = 0;
            segundos += 1;
        }

        if(segundos <= 9)
        {
            cajaSegundos.GetComponent<Text>().text = "0" + segundos + ".";
        }
        else
        {
            cajaSegundos.GetComponent<Text>().text = "" + segundos + ".";
        }

        if(minutos >= 60)
        {
            segundos = 0;
            minutos += 1;
        }

        if(minutos <= 9)
        {
            cajaMinutos.GetComponent<Text>().text = "0" + minutos + ":";
        }
        else
        {
            cajaMinutos.GetComponent<Text>().text = "" + minutos + ":";
        }
    }
}
