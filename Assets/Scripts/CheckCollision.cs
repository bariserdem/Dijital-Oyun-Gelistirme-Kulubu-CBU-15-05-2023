using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public Rigidbody ballRB;
    public bool isFinished = false;
    public GameObject restartPanel;

    private void Start()
    {
        restartPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Game Over");
            isFinished = true;
            restartPanel.SetActive(true);
        }
    }
}
