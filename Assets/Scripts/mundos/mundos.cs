using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mundos : MonoBehaviour
{
    public static mundos Instance;
     public Sprite mundoMato;
     public Sprite mundoPraia;
     public Sprite mundoCidade;
      public static List<string> nome_mundos;
       void Awake(){
    	Instance = this;
        LoadListaDeMundo();
        }
          void Start(){
            // PlayerPrefs.DeleteAll();
          }
    // Start is called before the first frame update

    void LoadListaDeMundo(){
        nome_mundos = new List<string>();
        nome_mundos.Add("Mundo 1");
        PlayerPrefs.SetString("nome_mundo_1", "Mundo 1");
    }
    public void addNovoMundo(string nome_mundo){
        if(nome_mundo == "Mundo 1"){
            nome_mundos.Add("Mundo 2");
            PlayerPrefs.SetString("nome_mundo_2", "Mundo 2");

        }
        if(nome_mundo == "Mundo 2"){
             nome_mundos.Add("Mundo 3");
            PlayerPrefs.SetString("nome_mundo_3", "Mundo 3");
        }
    }
    public void loadMunoLiberados(){
        if(nome_mundos.Count <= 1){
            int index = 1;
            while(PlayerPrefs.HasKey("nome_mundo_"+index)){
                if(!nome_mundos.Contains("nome_mundo_"+index)){
                    nome_mundos.Add(PlayerPrefs.GetString("nome_mundo_"+index));
                }
                index++;
           }
        }
    }

     public void liberarMundos(){
        foreach(Transform mundo in transform){
            mundo.GetComponent<Button>().interactable = true;
            if(nome_mundos.Contains(mundo.name)){
                if(mundo.name == "Mundo 1"){
                    mundo.GetComponent<Image>().sprite = mundoMato;
                }
                if(mundo.name == "Mundo 2"){
                    mundo.GetComponent<Image>().sprite = mundoPraia;
                }
                if(mundo.name == "Mundo 3"){
                     mundo.GetComponent<Image>().sprite = mundoCidade;
                }
                mundo.gameObject.SetActive(true);
            }
            else{
                mundo.GetComponent<Button>().interactable = false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        loadMunoLiberados();
        liberarMundos();
        
    }
}
