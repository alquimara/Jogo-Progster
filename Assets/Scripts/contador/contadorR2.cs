using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class contadorR2 : MonoBehaviour
{
    public static contadorR2 Instance;
    public InputField inputField2;
    public string R2input;
    public int contador2R2;
     void Awake(){
        Instance = this;
        inputField2 = GameObject.Find("Contador_R2").GetComponent<InputField>();
    }
    void Update(){
        R2input = inputField2.text;
        if(R2input != ""){
            contador2R2 = int.Parse(R2input);
            if(contador2R2 < 2 || contador2R2 > 5){
                inputField2.text = "";
                contador2R2 = 0;      
            }
        }
    }

    void Start(){
        inputField2.text = "2";
    }    
    
}
