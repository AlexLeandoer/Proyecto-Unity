using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMarca : MonoBehaviour {


    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CocheTipo1")
        {
            GameObject.Find("Tracker").GetComponent<CocheTipo1Tracker>().MarkTracker += 1;
            this.GetComponent<BoxCollider>().enabled = false;
            if (GameObject.Find("Tracker").GetComponent<CocheTipo1Tracker>().MarkTracker == 13)
            {
                GameObject.Find("Tracker").GetComponent<CocheTipo1Tracker>().MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
