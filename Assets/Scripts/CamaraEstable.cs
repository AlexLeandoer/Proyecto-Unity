using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraEstable : MonoBehaviour {

    public GameObject coche;
    public float cocheX;
    public float cocheY;
    public float cocheZ;

	void Update () {
        cocheX = coche.transform.eulerAngles.x;
        cocheY = coche.transform.eulerAngles.y;
        cocheZ = coche.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(cocheX - cocheX, cocheY, cocheZ - cocheZ);
    }
}
