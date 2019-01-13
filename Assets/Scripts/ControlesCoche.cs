using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ControlesCoche : MonoBehaviour {

	public GameObject controles;

    //Activo los controles del coche

    void Start()
    {
        controles.GetComponent<CarController>().enabled = true;
    }
}
