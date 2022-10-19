using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Best : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public int MilliCount;
    public int Coins;
    public GameObject sec;
    public GameObject milli;
    public GameObject min;
    public GameObject coinn;



    // Start is called before the first frame update
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetInt("MilliSave");
        Coins = PlayerPrefs.GetInt("Coins");
        min.GetComponent<TextMeshProUGUI>().text = "" + MinCount + ":";
        sec.GetComponent<TextMeshProUGUI>().text = "" + SecCount + ":";
        milli.GetComponent<TextMeshProUGUI>().text = "" + MilliCount + ":";
        coinn.GetComponent<TextMeshProUGUI>().text = "" + Coins ;
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
