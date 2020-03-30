using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class execucao : MonoBehaviour{

    public Transform[] obj;
    public static GameObject peca;
    public static execucao Instance;
    public GameObject R1Slot;
    public GameObject R2Slot;
    public GameObject R3Slot;
    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }

    public IEnumerator Executar2(){
        foreach(var ob in obj.Where(ob => (ob != transform))){
            if(ob.transform.childCount != 0){
                if(ob.transform.GetChild(0).tag == "andar"){
                    movimento.Instance.Andar();
                    yield return new WaitForSeconds(0.5F);
                }
                if(ob.transform.GetChild(0).tag == "pular" && movimento.grounded){
                    movimento.Instance.Pular();
                    yield return new WaitForSeconds(1.5F);
                }
                if(ob.transform.GetChild(0).tag == "subir" && movimento.subir){
                    movimento.Instance.Subir();
                    yield return new WaitForSeconds(2F);
                }
                 if(ob.transform.GetChild(0).tag == "descer" && movimento.descer){
                    movimento.Instance.Descer();
                    yield return new WaitForSeconds(2F);
                }
                else if(ob.transform.GetChild(0).tag == "R1"){
                    yield return StartCoroutine(R1execucao.Instance.R1exe());
                }
                else if(ob.transform.GetChild(0).tag == "R2"){
                    yield return StartCoroutine(R2execucao.Instance.R2exe());
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
        Play.play = 0;
}	}
