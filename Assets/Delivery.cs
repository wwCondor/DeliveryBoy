using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour {
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1); 
    bool hasPackage = false;
    int deliveriesCompleted = 0;

    SpriteRenderer playerCarSpriteRenderer;

    private void Start() {
        playerCarSpriteRenderer = GetComponent<SpriteRenderer>();
        playerCarSpriteRenderer.color = (hasPackage) ? hasPackageColor : noPackageColor;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package") {
            if (hasPackage == false) {
                hasPackage = true;
                playerCarSpriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
                Debug.Log("Got package");
            } else {
                Debug.Log("Car is full!");
            }
        } else if (other.tag == "Customer") {
            if (hasPackage == true) {
                hasPackage = false;
                playerCarSpriteRenderer.color = noPackageColor;
                deliveriesCompleted = deliveriesCompleted + 1;
                Debug.Log("Delivered package!");
                Debug.Log(deliveriesCompleted);
            } else {
                Debug.Log("We don't have a packages!");
            }
        }
    }
}
