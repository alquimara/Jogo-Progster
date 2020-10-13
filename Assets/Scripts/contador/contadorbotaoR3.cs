using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class contadorbotaoR3 : MonoBehaviour
{
    public Text contadorbotao;
    public int quantidadeR3;
    public static contadorbotaoR3 Instance;
    public  int contador3R3;
      void Awake(){
        Instance = this;
      }
    // Start is called before the first frame update
    void Start()
    {
        quantidadeR3 = 2;
        contadorbotao.text = quantidadeR3.ToString();
        contador3R3 = int.Parse(contadorbotao.text);    
    }

    // Update is called once per frame
  public void Aumentar(){
      if(this.quantidadeR3 >= 2 && this.quantidadeR3 < 5){
        this.quantidadeR3 +=1;
        contadorbotao.text = this.quantidadeR3.ToString();
        contador3R3 = int.Parse(contadorbotao.text); 

      }
    }
    public void Diminuir(){
      if(this.quantidadeR3 > 2 && this.quantidadeR3 <=5){
        this.quantidadeR3 -=1;
        contadorbotao.text = this.quantidadeR3.ToString();
        contador3R3 = int.Parse(contadorbotao.text);  
      }

    }

}
