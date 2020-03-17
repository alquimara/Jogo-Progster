using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandLer : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject pecaDragging;
    Vector3 startPosition;
	Transform startParent;
    Transform DragParent;
  
  private void Start() 
    {
        DragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        pecaDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(DragParent);

    }

    public void OnDrag(PointerEventData eventData)
    {
         Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        pecaDragging = null;
        if(transform.parent == DragParent){
            transform.position = startPosition;
            transform.SetParent(startParent);

        }

    }
    



    private void Update()
    {

    }
}