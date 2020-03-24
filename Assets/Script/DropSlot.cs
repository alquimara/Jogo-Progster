using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour, IDropHandler

{
    
       public GameObject peca;
       public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("eSTOU NO DROP");

        if (!peca)
        {
            peca = DragHandler.pieceDragging;
            peca.transform.SetParent(transform);
            peca.transform.position = transform.position;
            movimento.acoes.Add("andar");
            Debug.Log(movimento.acoes[0]);
            
        }
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        if (peca != null && peca.transform.parent != transform)
        {
            Debug.Log("FORA");
            peca = null;
        }
    }
        
    }
