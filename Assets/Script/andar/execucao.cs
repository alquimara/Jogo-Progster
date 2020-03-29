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
                        for(int i=0;i<contadorR1.Instance.contador1R1;i++){
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
                else if(ob.transform.GetChild(0).tag == "R2"){
                    if(R2Slot.transform.childCount != 0){
                        for(int i=0;i<contadorR2.Instance.contador2R2;i++){
                            Debug.Log("r2");
                           if(R2Slot.transform.GetChild(0).tag == "andar"){
                                movimento.Instance.Andar();
                                yield return new WaitForSeconds(0.5F);
                            }
                            if(R2Slot.transform.GetChild(0).tag == "pular"){
                                movimento.Instance.Pular();
                                yield return new WaitForSeconds(1.5F);
                            }
                        }
                    }
                }

                else if(ob.transform.GetChild(0).tag == "R3"){
                    if(R3Slot.transform.childCount != 0){
                        for(int i=0;i<contadorR3.Instance.contador3R3;i++){
                           if(R3Slot.transform.GetChild(0).tag == "andar"){
                                movimento.Instance.Andar();
                                yield return new WaitForSeconds(0.5F);
                            }
                            if(R3Slot.transform.GetChild(0).tag == "pular"){
                                movimento.Instance.Pular();
                                yield return new WaitForSeconds(1.5F);
                            }
                        }
                    }
                }
                else if(ob.transform.GetChild(0).tag == "F1"){
                   StartCoroutine( F1execucao.Instance.F1exe());
                }
                else if(ob.transform.GetChild(0).tag == "F2"){
                    StartCoroutine(F2execucao.Instance.F2exe());

                }

            }
        }
        start.play = 0;
}	}
