/*
 * Jaden Pleasants
 * Assignment 5A
 * Manages score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUtil : MonoBehaviour {
    private int score = 0;

    public Text scoreText;

    private void Start() {
        score = 0;
        scoreText.text = $"Score: {score}";
    }

    public void AddPoint() {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
