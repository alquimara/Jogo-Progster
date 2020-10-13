using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class execucaoTutorial : MonoBehaviour{

    public Transform[] obj;
    public static execucaoTutorial Instance;
    public static bool executando;    
    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }

    void Start(){
        executando = false;
        
    }
  

    public IEnumerator Executar2(){
        executando = true;
        foreach(var ob in obj.Where(ob => (ob != transform))){
            if(ob.transform.childCount != 0){
                if(ob.transform.GetChild(0).tag == "andar" && executando ){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    StartCoroutine(movimento.Instance.Andando());
                    yield return new WaitForSeconds(1F);
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(0.8F);
                   
                }
                if(ob.transform.GetChild(0).tag == "pular" && (movimento.grounded || movimento.Instance.plataform) && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    StartCoroutine(movimento.Instance.Pular());
                    yield return new WaitForSeconds(1F);
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(1F);
                }
                if(ob.transform.GetChild(0).tag == "subir" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    StartCoroutine(movimento.Instance.Subir());
                    yield return new WaitForSeconds(1.5F);
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                }
                 if(ob.transform.GetChild(0).tag == "descer" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    StartCoroutine(movimento.Instance.Descer());
                    yield return new WaitForSeconds(1F);
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                }
                else if(ob.transform.GetChild(0).tag == "R1" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    yield return new WaitForSeconds(1F);
                    yield return StartCoroutine(R1execucao.Instance.R1exe());
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(0.7F);
                }
                else if(ob.transform.GetChild(0).tag == "R2" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    yield return new WaitForSeconds(1F);
                    yield return StartCoroutine(R2execucao.Instance.R2exe());
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(0.7F);
                }
                else if(ob.transform.GetChild(0).tag == "R3" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                     yield return new WaitForSeconds(1F);
                    yield return StartCoroutine(R3execucao.Instance.R3exe());
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                     yield return new WaitForSeconds(0.7F);
                }
                else if(ob.transform.GetChild(0).tag == "F1" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    yield return new WaitForSeconds(1F);
                    yield return StartCoroutine(F1execucao.Instance.F1exe());
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(0.7F);
                }
                else if(ob.transform.GetChild(0).tag == "F2" && executando){
                    ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    yield return new WaitForSeconds(1F);
                    yield return StartCoroutine(F2execucao.Instance.F2exe());
                    ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                    yield return new WaitForSeconds(0.7F);

                }

            }
        }
        Play.play = 0;
        executando = false;
}	}
