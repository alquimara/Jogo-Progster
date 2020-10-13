using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botao : MonoBehaviour
{
    public static botao Instance;
    void Awake(){
        Instance = this;
    }
    void OnMouseDown(){
        StartCoroutine(movimentGrid.Instance.Andando());
       // movimentGrid.Instance.Andar();
    }
}
