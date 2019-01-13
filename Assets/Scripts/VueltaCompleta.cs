using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VueltaCompleta : MonoBehaviour {

    public GameObject TriggerMeta;
    public GameObject TriggerMetaMitad;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject miliDisplay;

    public GameObject caja_minutos;
    public GameObject caja_vueltas;
    public int vueltas;

    void OnTriggerEnter() {
        vueltas += 1;
		if(LapTimeManager.segundos <= 9)
        {
            secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.segundos + ".";
        }
        else
        {
            secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.segundos + ".";
        }

        if(LapTimeManager.minutos <= 9)
        {
            minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minutos + ".";
        }
        else
        {
            minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minutos + ".";
        }

        miliDisplay.GetComponent<Text>().text = "" + LapTimeManager.mili;

        LapTimeManager.minutos = 0;
        LapTimeManager.segundos = 0;
        LapTimeManager.mili = 0;
        caja_minutos.GetComponent<Text>().text = "" + vueltas;

        TriggerMetaMitad.SetActive(true);
        TriggerMeta.SetActive(false);
    }
}
