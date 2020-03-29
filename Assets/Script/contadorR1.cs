using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class contadorR1 : MonoBehaviour{

    public static contadorR1 Instance;
    public InputField inputField;
    public string R1input;
    public int contador1R1;

   void Awake(){
        Instance = this;
        inputField = GameObject.Find("contadorR1").GetComponent<InputField>();
    }
    void Update(){
        R1input = inputField.text;
        if(R1input != ""){
            contador1R1 = int.Parse(R1input);
            if(contador1R1 < 2 || contador1R1 > 5){
                inputField.text = "";
                contador1R1 = 0;      
            }
        }
    }

    void Start(){
        inputField.text = "2";
    }    
}
