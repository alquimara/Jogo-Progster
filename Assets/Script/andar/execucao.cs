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
     public static List<string> R12 = new List<string>();
       void Awake()
     {
        Instance = this;
        obj = GetComponentsInChildren<Transform>(true);
     }
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
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
                        foreach(string r in R12){
                            if(r == "andar"){
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

   /* public int getChildren(GameObject obj)
{
    int count = 0;

    for (int i = 0; i < obj.transform.childCount; i++)
    {
        count++;
        counter(obj.transform.GetChild(i).gameObject, ref count);
    }
    return count;
}

private void counter(GameObject currentObj, ref int count)
{
    for (int i = 0; i < currentObj.transform.childCount; i++)
    {
        count++;
        counter(currentObj.transform.GetChild(i).gameObject, ref count);
    }
}*/
}
