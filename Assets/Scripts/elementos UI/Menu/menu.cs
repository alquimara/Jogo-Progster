using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour

{
    public Sprite PauseApertado;
    public Sprite PauseElevado;
    public Image ImageSprite; 
    public GameObject panel;
    public bool ispause = false;
    public static int Cena = 0;
    // Start is called before the first frame update
   
   void Start(){
        ImageSprite = GetComponent<Image>();
        Debug.Log(ImageSprite.sprite);
   }
   public void Jogar() {
        SceneManager.LoadScene("Mundos");
    }
    public void Sair(){
        Application.Quit();
    }
      public void continuar(){
        if(Cena != 0 && Cena <= 6){
            int indexCena = Cena;
            movimento.sementeComida = new List<GameObject>();
            SceneManager.LoadScene(indexCena);
        }
        else{
            SceneManager.LoadScene("Mundos");
        }
        
    }
    public void pause(){
        if(ispause){
            // ImageSprite.sprite = PauseElevado;
            panel.SetActive(false);
            ispause = false;
        }
        else{
            // ImageSprite.sprite = PauseApertado;
            panel.SetActive(true);
            ispause = true;
        }
    }
    public void fases(){
        SceneManager.LoadScene("Fases");

    }
     public void menuPrincipal(){
        SceneManager.LoadScene("Menu");

    }
     public void tutorial(){
         SceneManager.LoadScene("tutorial2");

     }
     public void tutorialRepeticao(){
         SceneManager.LoadScene("tutorial6");
     }
     public void tutorialFuncao(){
         SceneManager.LoadScene("tutorial7");
     }

      public void Fasesmundo1(){
         SceneManager.LoadScene("FasesMundo1");

     }
      public void Fasesmundo2(){
         SceneManager.LoadScene("FasesMundo2");

     }
      public void Fasesmundo3(){
         SceneManager.LoadScene("FasesMundo3");

     }
}
