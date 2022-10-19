using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class RestartButton : MonoBehaviour
{
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MillDisplay;
    public int MinCount;
    public int SecCount;
    public int MilliCount;
   
    private void Start()
    {
        

    }
    public void Reset()
    {

        SceneManager.LoadScene("Racing Area1");
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetInt("MilliSave");

        MinDisplay.GetComponent<TextMeshProUGUI>().text = "00.";
        SecDisplay.GetComponent<TextMeshProUGUI>().text = "00.";
        MillDisplay.GetComponent<TextMeshProUGUI>().text = "0.";

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

    }
}
