using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SegundoControle : MonoBehaviour
{
    public int Min;
    public int Max;
    public int numero;
    public Text numerotxt;
    public static int numerotexto;

    public static int conteudo;

    // Start is called before the first frame update
    void Start()
    {
        numero = Random.Range(Min, Max);
        numerotexto = numero;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(conteudo);
        numerotxt.text = numerotexto.ToString();

        if(conteudo == numero)
        {
            conteudo = 0;
            SceneManager.LoadScene("Fase2");
            
        }
    }

   
}
