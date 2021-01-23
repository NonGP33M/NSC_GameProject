using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

public void Restart()
{
    SceneManager.LoadScene("Scene1");
    Time.timeScale = 1f;
    KillFloor.R = 0;
}
public void Quit()
{
    Application.Quit();
}
}
