using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class R2execucao : MonoBehaviour
{
     public Transform[] obj;
    public static R2execucao Instance;
    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }

    public IEnumerator R2exe(){

        foreach(var ob in obj.Where(ob => (ob != transform))){
            if(ob.transform.childCount != 0){
                for(int i=0;i<contadorR2.Instance.contador2R2;i++){
                    if(ob.transform.GetChild(0).tag == "andar"){
                        movimento.Instance.Andar();
                        yield return new WaitForSeconds(0.5F);
                    }
                    if(ob.transform.GetChild(0).tag == "pular"){
                        movimento.Instance.Pular();
                        yield return new WaitForSeconds(1.5F);
                    }
                    if(ob.transform.GetChild(0).tag == "R1"){
                         yield return StartCoroutine(R1execucao.Instance.R1exe());

                    }
                    else if(ob.transform.GetChild(0).tag == "R3"){
                        yield return StartCoroutine(R3execucao.Instance.R3exe());

                    }
                    else if(ob.transform.GetChild(0).tag == "F1"){
                        yield return StartCoroutine(F1execucao.Instance.F1exe());
                    }
                    else if(ob.transform.GetChild(0).tag == "F2"){
                        yield return StartCoroutine(F2execucao.Instance.F2exe());
                    }
                                 
                }
            }
        }
    }
}
