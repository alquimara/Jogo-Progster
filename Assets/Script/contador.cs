using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
 using System.Text.RegularExpressions;

public class contador : MonoBehaviour
{
    public static contador Instance;
    public Text input;

    public string R1input;
    public int contadorR1;
   
    
    // Start is called before the first frame update


    // Update is called once per frame
   void Awake(){
    Instance = this;
  }
    void Update()
    {
        R1input = input.text;
        if(R1input != ""){
            contadorR1 = int.Parse(R1input);
            if(contadorR1 < 2 || contadorR1 > 5){
                input.text = null;
                
                Debug.Log("estou no if ");

               
            }
            else{
                Debug.Log("estou no else");
            }
            
        }
    
    }

    void Start(){
        input.text = "2";
    }

    
}
