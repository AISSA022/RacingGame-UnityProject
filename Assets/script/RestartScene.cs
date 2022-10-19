using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartScene : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public int MilliCount;
    public void Resetsenes()
    {

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        SceneManager.LoadScene("Racing Area1");
    }
}
