using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string patente;
    public int anio;
    public float km;
    public int vto;
    public int hc;
    float promedio;
    // Start is called before the first frame update
    void Start()
    {
        if (patente==("") || anio <1900 || km< 0 || vto <anio || vto > 2025 || hc <5 || hc >100)
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        promedio = km / (2025 - anio);
        if (promedio < 10000)
        {
            Debug.Log("VTV otorgada por dos años");
        }
        else
        {
            Debug.Log("VTV otorgada por un año");
        }
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
