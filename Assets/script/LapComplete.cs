using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrigger;

    public GameObject MinuteDisplay;
    public GameObject secondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if (LapTimeManager.SecondCount <= 9)
        {
            secondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ":";
        }
        else
        {
            secondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ":";
        }
        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ":";

        }

        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + (int)(LapTimeManager.MilliCount);

        PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);


        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        //HalfLapTrigger.SetActive(true);
        //LapCompleteTrig.SetActive(false);
    }
}
