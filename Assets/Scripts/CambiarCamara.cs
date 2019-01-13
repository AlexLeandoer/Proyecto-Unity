using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour {

    public GameObject CamaraNormal;
    public GameObject CamaraLejos;
    public GameObject PrimeraPersona;
    public int CamMode;

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            CamaraNormal.SetActive(true);
            PrimeraPersona.SetActive(false);
        }
        if (CamMode == 1)
        {
            CamaraLejos.SetActive(true);
            CamaraNormal.SetActive(false);
        }
        if (CamMode == 2)
        {
            PrimeraPersona.SetActive(true);
            CamaraLejos.SetActive(false);
        }

    }
}
