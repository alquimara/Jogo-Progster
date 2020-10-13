using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class passandoFase : MonoBehaviour{
    public GameObject vitoria;
    public static passandoFase Instance;
    public void Awake(){
        Instance = this;
    }

    
    // Start is called before the first frame update
    IEnumerator OnTriggerEnter2D(Collider2D Obj){
        while(execucao.executando){
            execucao.executando = false;
            yield return new WaitForSeconds(2F);
        }
        if(Obj.gameObject.tag == "personagem"){
            vidas.Instance.ganharVida((movimento.sementeComida).Count);
            Debug.Log(movimento.sementeComida.Count);
            fases.Instance.guardarSementes(SceneManager.GetActiveScene().name, (movimento.sementeComida).Count);
            yield return new WaitForSeconds(2F);
            if(SceneManager.GetActiveScene().name == "Fase 3"|| SceneManager.GetActiveScene().name == "Fase 6" || SceneManager.GetActiveScene().name == "Fase 9"){
                // vitoria.SetActive(true);
            }
            else if(SceneManager.GetActiveScene().name == "Fase 4" || SceneManager.GetActiveScene().name == "Fase 5" || SceneManager.GetActiveScene().name == "Fase 6"){
                 SceneManager.LoadScene("FasesMundo2");
            }
            else if(SceneManager.GetActiveScene().name == "Fase 7" || SceneManager.GetActiveScene().name == "Fase 8" || SceneManager.GetActiveScene().name == "Fase 9"){
                SceneManager.LoadScene("FasesMundo3");
            }
            else if(SceneManager.GetActiveScene().name == "Fase 1" || SceneManager.GetActiveScene().name == "Fase 2" || SceneManager.GetActiveScene().name == "Fase 3"){
                SceneManager.LoadScene("FasesMundo1");
            }
            movimento.sementeComida = new List<GameObject>();
        }
    }
}
