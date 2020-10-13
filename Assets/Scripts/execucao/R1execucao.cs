using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;


public class R1execucao : MonoBehaviour{
    public Transform[] obj;
    public static R1execucao Instance;
    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }

    public IEnumerator R1exe(){
        foreach(var ob in obj.Where(ob => (ob != transform))){
            if(ob.transform.childCount != 0){
                for(int i=0;i<contadorbotaoR1.Instance.contador1R1;i++){
                    if(ob.transform.GetChild(0).tag == "andar" && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        StartCoroutine(movimento.Instance.Andando());
                        yield return new WaitForSeconds(1F);
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
        
                    }
                    if(ob.transform.GetChild(0).tag == "pular" && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        StartCoroutine(movimento.Instance.Pular());
                        yield return new WaitForSeconds(1F);
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                       
                    }
                    if(ob.transform.GetChild(0).tag == "subir" && movimento.subir && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        movimento.Instance.Subir();
                        yield return new WaitForSeconds(1F);
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                     
                    }
                    if(ob.transform.GetChild(0).tag == "descer" && movimento.descer && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        movimento.Instance.Descer();
                        yield return new WaitForSeconds(1F);
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                       
                    }
                    if(ob.transform.GetChild(0).tag == "R2" && execucao.executando){
                         ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                         yield return new WaitForSeconds(1F);
                         yield return StartCoroutine(R2execucao.Instance.R2exe());
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                        yield return new WaitForSeconds(1F);

                    }
                    else if(ob.transform.GetChild(0).tag == "R3" && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        yield return StartCoroutine(R3execucao.Instance.R3exe());
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                        yield return new WaitForSeconds(1F);

                    }
                    else if(ob.transform.GetChild(0).tag == "F1" && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        yield return StartCoroutine(F1execucao.Instance.F1exe());
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                        yield return new WaitForSeconds(1F);
                    }
                    else if(ob.transform.GetChild(0).tag == "F2" && execucao.executando){
                        ob.GetChild(0).transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                        yield return new WaitForSeconds(1F);
                        yield return StartCoroutine(F2execucao.Instance.F2exe());
                        ob.GetChild(0).transform.localScale = new Vector3(1f,1f,1f);
                        yield return new WaitForSeconds(1F);
                    }
                }
            }
        }
    }
}
