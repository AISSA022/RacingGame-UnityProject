using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public int MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetInt("MilliSave");

        MinDisplay.GetComponent<TextMeshProUGUI>().text = "" + MinCount;
        SecDisplay.GetComponent<TextMeshProUGUI>().text = "" +SecCount;
        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + MilliCount;

    }


}
