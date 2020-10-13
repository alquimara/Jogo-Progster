 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class contadorbotaoR1 : MonoBehaviour
{
    public Text contadorbotao;
    public int quantidadeR1;
    public static contadorbotaoR1 Instance;
    public  int contador1R1;
      void Awake(){
        Instance = this;
      }
    // Start is called before the first frame update
    void Start()
    {
        this.quantidadeR1 = 2;
        contadorbotao.text = quantidadeR1.ToString(); 
        contador1R1 = int.Parse(contadorbotao.text);   
    }

    // Update is called once per frame
   public void Aumentar(){
      if(this.quantidadeR1 >= 2 && this.quantidadeR1 < 5){
        this.quantidadeR1 +=1;
        contadorbotao.text = this.quantidadeR1.ToString();
        contador1R1 = int.Parse(contadorbotao.text); 

      }
      if(SceneManager.GetActiveScene().name == "tutorial6"){
        repeticaoTutorial.Instance.mao.SetActive(false);
        repeticaoTutorial.Instance.texto5.SetActive(false);
        repeticaoTutorial.Instance.texto6.SetActive(true);
        fase1Tutorial.Instance.maoarraste2.SetActive(true);
        StartCoroutine(tempo());
      }

    }
    public void Diminuir(){
      if(this.quantidadeR1 > 2 && this.quantidadeR1 <=5){
        this.quantidadeR1 -=1;
        contadorbotao.text = this.quantidadeR1.ToString();
        contador1R1 = int.Parse(contadorbotao.text);  
      }


    }
    public IEnumerator tempo(){
    yield return new WaitForSeconds(3F);
     fase1Tutorial.Instance.maoarraste2.SetActive(false);
}
    
}
