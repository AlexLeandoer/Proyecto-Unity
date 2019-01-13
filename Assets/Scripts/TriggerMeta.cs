using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMeta : MonoBehaviour {

    public GameObject VueltaCompletaTrig;
    public GameObject MediaVueltaTrig;
	void OnTriggerEnter () {
        VueltaCompletaTrig.SetActive(true);
        MediaVueltaTrig.SetActive(true);
	}
}
