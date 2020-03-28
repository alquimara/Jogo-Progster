using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour, IDropHandler

{
       public static GameObject peca;
       public static List<GameObject> acoes2 = new List<GameObject>();
       public static int tamanho;
       public static DropSlot Instance;

    void Awake(){
    Instance = this;
  }
       public void OnDrop(PointerEventData eventData)
    {
        if (!peca)
        {
            peca = DragHandler.pieceDragging;
            peca.transform.SetParent(transform);
            peca.transform.position = transform.position;
           
            //if(DragHandler.pieceDragging == peca){
            //    acoes2.Remove(peca);
           // }
            
            
           /* Debug.Log(tamanho + "drop");
            if(tamanho>=1){
            foreach(GameObject g in acoes2){
            Debug.Log(tamanho + "inicial");
            if(DragHandler.pieceDragging == g){
              Debug.Log("estou dentro do 2 if" + DragHandler.pieceDragging);
             
            }

        }

        } */
                    
            /*if(peca.tag == "andar"){
                movimento.acoes.Add("andar");
            }
            else if(peca.tag == "R1"){
                movimento.acoes.Add("R1");
            }*/
        }
    }  

    void Update()
    {
        //GameObject filho = slots.GetChild(0).gameObject;
        //GameObject pecaEncaixada = filho.GetChild(0).gameObject;
       
        if (peca != null && peca.transform.parent != transform)
        {
            peca = null;
        }
    }
}
        
    
