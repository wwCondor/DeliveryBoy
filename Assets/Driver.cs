using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver: MonoBehaviour {

    [Header("Car Specs")]
    [SerializeField] float turnSpeed = 120f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float normalSpeed = 15f;
    [SerializeField] float boostSpeed = 25f;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "SpeedBoost") {
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = normalSpeed;
    }

    void Update()  {
        float turnSpeedAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -turnSpeedAmount);
        transform.Translate(0, speedAmount, 0);
    }
}
