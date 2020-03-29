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
    public static List<GameObject> R1 = new List<GameObject>();

    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }
    
    public IEnumerator Executar2(){
        foreach(var ob in obj.Where(ob => (ob != transform))){
            yield return new WaitForSeconds(0.5F);
            if(ob.transform.childCount != 0){
                if(ob.transform.GetChild(0).tag == "andar"){
                    movimento.Instance.Andar();
                    yield return new WaitForSeconds(0.5F);
                }
                if(ob.transform.GetChild(0).tag == "pular" && movimento.grounded){
                    movimento.Instance.Pular();
                    yield return new WaitForSeconds(1.5F);
                }
                else if(ob.transform.GetChild(0).tag == "R1"){
                    if(R1Slot.transform.childCount != 0){
                        for(int i=0;i<contador.Instance.contadorR1;i++){
                           if(R1Slot.transform.GetChild(0).tag == "andar"){
                                movimento.Instance.Andar();
                                yield return new WaitForSeconds(0.5F);
                            }
                            if(R1Slot.transform.GetChild(0).tag == "pular"){
                                movimento.Instance.Pular();
                                yield return new WaitForSeconds(1.5F);
                            }
                        }
                    }
                }
            }
        }
        start.play = 0;
}	}
