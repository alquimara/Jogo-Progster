using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropR1 : MonoBehaviour,  IDropHandler{
    public static DropR1 Instance;
    public GameObject peca;
    public  int R1count;
    
    void Awake(){
        Instance = this;
    }
       public void OnDrop(PointerEventData eventData){
        if (!peca){
            peca = DragHandler.pieceDragging;
            if(transform.name == "Slot_R1" && peca.tag != "R1") DropPeca();
            if(transform.name == "Slot_R2" && peca.tag != "R2") DropPeca();
            if(transform.name == "Slot_R3" && peca.tag != "R3") DropPeca();
            if(transform.tag == "Slot_F1" && peca.tag != "F1") DropPeca();
            if(transform.tag == "Slot_F2" && peca.tag != "F2") DropPeca();
        } 
    }
    public void DropPeca(){
        peca.transform.SetParent(transform);
        peca.transform.position = transform.position;

    }

     void Update(){
        if (peca != null && peca.transform.parent != transform){
            peca = null;
        }
    }
}