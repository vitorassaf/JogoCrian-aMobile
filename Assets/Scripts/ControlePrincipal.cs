using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePrincipal : MonoBehaviour
{
    public int Min;
    public int Max;
    public int numero;
    public Text numerotxt;

    

    void Start()
    {
        numero = Random.Range(Min, Max);

    }


    void Update()
    {
        numerotxt.text = numero.ToString();


        if (Input.touchCount == numero)
        {
            numero = Random.Range(Min, Max);
        }
    }

}
