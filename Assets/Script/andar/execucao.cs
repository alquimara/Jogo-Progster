using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class execucao : MonoBehaviour
{
     public Transform[] obj;
     public static GameObject peca;
     public static execucao Instance;
     public static List<GameObject> R1 = new List<GameObject>();
       void Awake()
     {
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
     }
    
    public IEnumerator Executar2(){
		yield return new WaitForSeconds(0.5F);
		foreach(var ob in obj.Where(ob => (ob != transform))){
            if(ob.transform.childCount !=0){
                 if(ob.transform.GetChild(0).tag == "andar"){
                    movimento.Instance.Andar();
                 }
                 else if(ob.transform.GetChild(0).tag == "R1"){
                    for(int i=0;i<contador.Instance.contadorR1;i++){
                        foreach(GameObject r in R1){
                            if(r.tag == "andar"){
                                movimento.Instance.Andar();
                            }
                            yield return new WaitForSeconds(0.5F);
                        }
                    }
			}
             }
			yield return new WaitForSeconds(0.5F);
		}
	}
}
