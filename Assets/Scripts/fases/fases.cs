using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fases : MonoBehaviour
{
    public static fases Instance;
    public static  List<int> sementesFases = new List<int>();
    public static  List<Transform> sementesImageActive = new List<Transform>();
   public Sprite comSemente;
    public static int qtd_sementes;
    public static List<string> nome_fases;
    public Sprite faseSpriteAtivo;

    void Awake(){
    	Instance = this;
        LoadListaDeFase();
        qtd_sementes = 0;
	}

    void Start(){
        // PlayerPrefs.DeleteAll();
        foreach(string fase in nome_fases){
            if(PlayerPrefs.HasKey(fase)){
                qtd_sementes = PlayerPrefs.GetInt(fase);
            }else{
                PlayerPrefs.SetInt(fase, qtd_sementes);
            }
        }       
    }

    void Update(){
        loadFasesLiberadas();
        liberarFases();
        preencherSementes();
    }

    public void guardarSementes(string fase, int qtd_sementes){
        PlayerPrefs.SetInt(fase, qtd_sementes);
        addNovaFase(fase);
    }

    public int getSementesPorFase(string fase){
        return PlayerPrefs.GetInt(fase);
    }

    void LoadListaDeFase(){
        nome_fases = new List<string>();
        nome_fases.Add("Fase 1");
        PlayerPrefs.SetString("nome_fase_1", "Fase 1");
    }

    public void preencherSementes(){
        foreach(Transform fase in transform){
            if(nome_fases.Contains(fase.name)){
                foreach(Transform sementesFases in fase){
                    int qtd = 1;
                    foreach(Transform semente in sementesFases){
                        if(qtd <= getSementesPorFase(fase.name)){
                            semente.GetComponent<Image>().sprite = comSemente;
                        }
                        qtd++;
                    }
                }
            }
        }
    }

    public void addNovaFase(string nome_fase){
        if(nome_fase == "Fase 1"){
            nome_fases.Add("Fase 2");
            PlayerPrefs.SetString("nome_fase_2", "Fase 2");
        }
        if(nome_fase == "Fase 2"){
            nome_fases.Add("Fase 3");
            PlayerPrefs.SetString("nome_fase_3", "Fase 3");
        }
        if(nome_fase == "Fase 3"){
            PlayerPrefs.SetString("nome_mundo_2", "Mundo 2");
            nome_fases.Add("Fase 4");
            PlayerPrefs.SetString("nome_fase_4", "Fase 4");
        }
        if(nome_fase == "Fase 4"){
            nome_fases.Add("Fase 5");
            PlayerPrefs.SetString("nome_fase_5", "Fase 5");
        }
        if(nome_fase == "Fase 5"){
            nome_fases.Add("Fase 6");
            PlayerPrefs.SetString("nome_fase_6", "Fase 6");
        }
        if(nome_fase == "Fase 6"){
            PlayerPrefs.SetString("nome_mundo_3", "Mundo 3");
            nome_fases.Add("Fase 7");
            PlayerPrefs.SetString("nome_fase_7", "Fase 7");
            
        }
        if(nome_fase == "Fase 7"){
            nome_fases.Add("Fase 8");
            PlayerPrefs.SetString("nome_fase_8", "Fase 8");
            
        }
        if(nome_fase == "Fase 8"){
            nome_fases.Add("Fase 9");
            PlayerPrefs.SetString("nome_fase_9", "Fase 9");
            
        }

    }

    public void loadFasesLiberadas(){
        if(nome_fases.Count <= 1){
            int index = 1;
            while(PlayerPrefs.HasKey("nome_fase_"+index)){
                if(!nome_fases.Contains("nome_fase_"+index)){
                    nome_fases.Add(PlayerPrefs.GetString("nome_fase_"+index));
                }
                index++;
           }
        }
    }

    public void liberarFases(){
        foreach(Transform fase in transform){
            fase.GetComponent<Button>().interactable = true;
            if(nome_fases.Contains(fase.name)){
                fase.GetComponent<Image>().sprite = faseSpriteAtivo;
                fase.gameObject.SetActive(true);
                foreach(Transform f in fase){
                    if(f.name == "sementes"){
                        foreach(Transform s in f){
                            s.gameObject.SetActive(true);
                        }
                    }
                    if(f.name == "Text"){
                        f.GetComponent<Text>().enabled = true;                        
                    }   
                }
            }
            else{
                fase.GetComponent<Button>().interactable = false;
                foreach(Transform f in fase){
                    if(f.name == "sementes"){
                        foreach(Transform s in f){
                            s.gameObject.SetActive(false);
                        }
                    }    
                    if(f.name == "Text"){
                        f.GetComponent<Text>().enabled = false;                        
                    }   
                }
            }
        }
    }
}
