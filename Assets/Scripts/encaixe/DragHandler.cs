using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler{

    public static GameObject pieceDragging;
    public static Vector3 startPosition;
	public static Transform startParent;
    public static Transform DragParent;
    public static DragHandler Instance;
     
    private void Start(){

        DragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    
    void Awake(){
        Instance = this;
    }

    public void OnBeginDrag(PointerEventData eventData){
   
        pieceDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(DragParent);
    }

    public void OnDrag(PointerEventData eventData){
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        pieceDragging = null;
        if(transform.parent == DragParent){
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
}