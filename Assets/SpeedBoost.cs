using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {


    private void Start() {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "SpeedBoost") {
            Debug.Log("Drove over speedboost");
        } else if (other.tag == "SpeedBump") {
            Debug.Log("Drove over speedBump");
        }
    }
}
