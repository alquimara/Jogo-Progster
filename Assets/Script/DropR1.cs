using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DropR1 : MonoBehaviour,  IDropHandler
{
    public static DropR1 Instance;
    public GameObject peca;
    public  int R1count;
    void Awake(){
    Instance = this;
  }
       public void OnDrop(PointerEventData eventData)
    {


        if (!peca)
        {
            Debug.Log(contador.Instance.contadorR1);
            peca = DragHandler.pieceDragging;
            peca.transform.SetParent(transform);
            peca.transform.position = transform.position;
            if(peca.tag == "andar"){
                movimento.R1.Add("andar");   
        }
    }
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
         if (peca != null && peca.transform.parent != transform)
        {
            peca = null;
        }
        
    }
}
}
