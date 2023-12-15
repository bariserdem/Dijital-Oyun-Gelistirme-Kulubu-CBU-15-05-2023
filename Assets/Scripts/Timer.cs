using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timer = 0;
    private bool isTimerRunning = false;

    
    public CheckCollision checkCollision;
    public TextMeshProUGUI timerText;
    public bool isTimerSet = false;

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        if (isTimerRunning && isTimerSet)
        {
            timer += Time.deltaTime;
        }

        if (isTimerSet && checkCollision.isFinished == false)
        {
            StartTimer();
        }
        if (isTimerRunning && checkCollision.isFinished == true)
        {
            StopTimer();
        }
        

        UpdateUI();
    }

    public void UpdateUI()
    {
        timerText.text = $"Time: {timer:#.00}";
    }

    public void ResetTimer()
    {
        timer = 0;
        isTimerSet = true;
    }

    public void StartTimer()
    {
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
        isTimerSet = false;
    }
}
