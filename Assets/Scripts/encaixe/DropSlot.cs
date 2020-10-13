using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropSlot : MonoBehaviour, IDropHandler{
    public static GameObject peca;
    public static int tamanho;
    public static DropSlot Instance;
    public bool quantidade;

    void Awake(){
        Instance = this;
    }
    
    public void OnDrop(PointerEventData eventData){
        
        if (!peca){
            peca = DragHandler.pieceDragging;
            if(transform.childCount == 0){
                peca.transform.SetParent(transform);
                peca.transform.position = transform.position;
            }
        }
    }

    void Update(){
        if (peca != null && peca.transform.parent != transform){
            peca = null;
        }
    }
   
}