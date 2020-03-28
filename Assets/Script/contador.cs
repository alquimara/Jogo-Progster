using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class contador : MonoBehaviour{

    public static contador Instance;
    public InputField inputField;
    public string R1input;
    public int contadorR1;

   void Awake(){
        Instance = this;
        inputField = GameObject.Find("contador").GetComponent<InputField>();
    }
    void Update(){
        R1input = inputField.text;
        if(R1input != ""){
            contadorR1 = int.Parse(R1input);
            if(contadorR1 < 2 || contadorR1 > 5){
                inputField.text = "";
                contadorR1 = 0;      
            }
        }
    }

    void Start(){
        inputField.text = "2";
    }    
}
