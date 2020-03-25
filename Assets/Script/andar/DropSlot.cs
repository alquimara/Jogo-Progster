﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropSlot : MonoBehaviour, IDropHandler

{
    
       public GameObject peca;
       public void OnDrop(PointerEventData eventData)
    {
        

        if (!peca)
        {
            peca = DragHandler.pieceDragging;
            peca.transform.SetParent(transform);
            peca.transform.position = transform.position;
            if(peca.tag == "andar"){
                movimento.acoes.Add("andar");
            }
            else if(peca.tag == "R1"){
                movimento.acoes.Add("R1");
            }
        }
    }  

    void Update()
    {
        if (peca != null && peca.transform.parent != transform)
        {
            peca = null;
        }
    }
}
        
    
