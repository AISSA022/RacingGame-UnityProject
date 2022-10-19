using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameras : MonoBehaviour
{
    public GameObject tcar;
    public float CarX;
    public float CarY;
    public float CarZ;

    // Update is called once per frame
    void Update()
    {
        CarX = tcar.transform.eulerAngles.x;
        CarY = tcar.transform.eulerAngles.y;
        CarZ = tcar.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}
