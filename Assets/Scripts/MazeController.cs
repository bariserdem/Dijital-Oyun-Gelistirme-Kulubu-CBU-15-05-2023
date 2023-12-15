using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeController : MonoBehaviour
{
    float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    float z;

    private void Update()
    {
        currentEulerAngles += new Vector3(0, 0, z) * Time.deltaTime * rotationSpeed;
        transform.localEulerAngles = currentEulerAngles;
    }

    public void RotateLeft()
    {
        z = 0.2f;
    }

    public void RotateRight()
    {
        z = -0.2f;
    }

    public void RotateStop()
    {
        z = -0;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
