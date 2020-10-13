using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class contadorbotaoR2 : MonoBehaviour
{
    public Text contadorbotao;
    public int quantidadeR2;
    public static contadorbotaoR2 Instance;
    public  int contador2R2;
      void Awake(){
        Instance = this;
      }
    // Start is called before the first frame update
    void Start()
    {
        quantidadeR2 = 2;
        contadorbotao.text = quantidadeR2.ToString();
        contador2R2 = int.Parse(contadorbotao.text);    
    }

 public void Aumentar(){
      if(this.quantidadeR2 >= 2 && this.quantidadeR2 < 5){
        this.quantidadeR2 +=1;
        contadorbotao.text = this.quantidadeR2.ToString();
        contador2R2 = int.Parse(contadorbotao.text); 

      }
    }
    public void Diminuir(){
      if(this.quantidadeR2 > 2 && this.quantidadeR2 <=5){
        this.quantidadeR2 -=1;
        contadorbotao.text = this.quantidadeR2.ToString();
        contador2R2 = int.Parse(contadorbotao.text);  
      }

    }

    }

    // Update is called once per frame
  
