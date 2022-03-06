/*
 * Jaden Pleasants
 * Assign 5A
 * Adds the "you win" text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinHandler : MonoBehaviour {
    public Text winText;

    void OnTriggerEnter2D(Collider2D theCollider) {
        if (theCollider.CompareTag("Player")) {
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
