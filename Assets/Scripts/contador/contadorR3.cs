using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class contadorR3 : MonoBehaviour
{
     public static contadorR3 Instance;
    public InputField inputField3;
    public string R3input;
    public int contador3R3;
     void Awake(){
        Instance = this;
        inputField3 = GameObject.Find("Contador_R3").GetComponent<InputField>();
    }
    void Update(){
        R3input = inputField3.text;
        if(R3input != ""){
            contador3R3 = int.Parse(R3input);
            if(contador3R3 < 2 || contador3R3 > 5){
                inputField3.text = "";
                contador3R3 = 0;      
            }
        }
    }

    void Start(){
        inputField3.text = "2";
    }    
}
