using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoandFases : MonoBehaviour
{
    void Awake(){
        tutorialmato = false;
    }
    public bool tutorialmato;
    // Start is called before the first frame update
     public void mundoMato(){
           Debug.Log(tutorialmato);
        SceneManager.LoadScene("FasesMundo1");
    }
    public void mundoPraia(){
         SceneManager.LoadScene("FasesMundo2");
    }
     public void mundoCidade(){
         SceneManager.LoadScene("FasesMundo3");
    }

    public void fase1(){
        SceneManager.LoadScene("Fase 1");
    }
    public void fase2(){
        SceneManager.LoadScene("Fase 2");
    }
    public void fase3(){
        SceneManager.LoadScene("Fase 3");
    }
    public void fase4(){
        SceneManager.LoadScene("Fase 4");
    }
    public void fase5(){
        SceneManager.LoadScene("Fase 5");
    }
     public void fase6(){
        SceneManager.LoadScene("Fase 6");
    }
    public void fase7(){
        SceneManager.LoadScene("Fase 7");
    }
    public void fase8(){
        SceneManager.LoadScene("Fase 8");
    }
    public void fase9(){
        SceneManager.LoadScene("Fase 9");
    }

    
   
   public void Historia(){
       tutorialmato= true;
         SceneManager.LoadScene("história");
         Debug.Log(tutorialmato);

     }
    public void Mundos(){
   
        SceneManager.LoadScene("Mundos");
    }
    public void menuPrincipal(){
       
        SceneManager.LoadScene("Menu");

    }
     public void tutorial(){
         SceneManager.LoadScene("tutorial2");

     }

     public void tutorialPraia(){
         SceneManager.LoadScene("tutorial6");

     }
     public void tutorialCidade(){
         SceneManager.LoadScene("tutorial7");

     }
     void update(){
         if(tutorialmato){
             fase1();
         }
         else{
             Historia();
         }
     }

}
