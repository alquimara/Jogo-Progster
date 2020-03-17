using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour, IDropHandler
{
       public GameObject peca;
       public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (!peca)
        {
            peca = DragHandLer.pecaDragging;
            peca.transform.SetParent(transform);
            peca.transform.position = transform.position;
        }
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        if (peca != null && peca.transform.parent != transform)
        {
            Debug.Log("Remover");
            peca = null;
        }
    }
        
    }
