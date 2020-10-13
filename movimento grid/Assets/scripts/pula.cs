using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pula : MonoBehaviour
{
    public static pula Instance;
    void Awake(){
        Instance = this;
    }
    void  OnMouseDown(){
        StartCoroutine(movimentGrid.Instance.Pular());
        
    }
}
