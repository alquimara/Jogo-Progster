using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class F1execucao : MonoBehaviour
{
    public Transform[] obj;
    public static F1execucao Instance;
    void Awake(){
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
    }

    public IEnumerator F1exe(){
         foreach(var ob in obj.Where(ob => (ob != transform))){
              if(ob.transform.childCount != 0){
                  if(ob.transform.GetChild(0).tag == "andar"){
                    movimento.Instance.Andar();
                    yield return new WaitForSeconds(0.5F);
                  }
                  if(ob.transform.GetChild(0).tag == "pular"){
                    movimento.Instance.Pular();
                    yield return new WaitForSeconds(1.5F);
                  }
              }
           
        }
    }
}
