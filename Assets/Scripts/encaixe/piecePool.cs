using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class piecePool : MonoBehaviour, IDropHandler{
    public bool podeEncaixar;
   
     public void OnDrop(PointerEventData eventData){
        if(DragHandler.pieceDragging == null) return;

        if(transform.name == "Pecas_Andar" && DragHandler.pieceDragging.transform.tag == "andar") Encaixepeca();
        
        if(transform.name == "Pecas_Pular" && DragHandler.pieceDragging.transform.tag == "pular") Encaixepeca();

        if(transform.name == "Pecas_Subir" && DragHandler.pieceDragging.transform.tag == "subir") Encaixepeca();

        if(transform.name == "Pecas_Descer" && DragHandler.pieceDragging.transform.tag == "descer") Encaixepeca();

        if(transform.name == "Pecas_R1" && DragHandler.pieceDragging.transform.tag == "R1") Encaixepeca();

        if(transform.name == "Pecas_R2" && DragHandler.pieceDragging.transform.tag == "R2") Encaixepeca();

        if(transform.name == "Pecas_R3" && DragHandler.pieceDragging.transform.tag == "R3") Encaixepeca();

        if(transform.name == "Pecas_F1" && DragHandler.pieceDragging.transform.tag == "F1") Encaixepeca();

        if(transform.name == "Pecas_F2" && DragHandler.pieceDragging.transform.tag == "F2") Encaixepeca();

    }
    public void Encaixepeca(){
        DragHandler.pieceDragging.transform.SetParent(transform);
        DragHandler.pieceDragging.transform.position = transform.position;

    }
    void Update(){
        // foreach(Transform t in transform.parent){
        // }
       // Debug.Log(transform.GetChild(0).tag == "R1");


    }
    
}
