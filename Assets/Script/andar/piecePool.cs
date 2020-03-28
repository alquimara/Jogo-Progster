using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class piecePool : MonoBehaviour, IDropHandler{

     public void OnDrop(PointerEventData eventData){
        if (DragHandler.pieceDragging == null) return;
        DragHandler.pieceDragging.transform.SetParent(transform);
        Debug.Log("estou dentro");
    }
}