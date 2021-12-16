using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    // Camera position should be same as player position
    [SerializeField] GameObject followObject;
    float cameraOffset = 15f;
    void LateUpdate() {
        transform.position = followObject.transform.position - new Vector3(0, 0 , cameraOffset);
    }
}
