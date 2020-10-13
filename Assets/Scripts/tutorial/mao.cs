using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mao : MonoBehaviour, IBeginDragHandler
{
    public static Transform DragParent;
    void start(){
           DragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
     public void OnBeginDrag(PointerEventData eventData){
        fase1Tutorial.Instance.maoarraste.SetActive(false);
        if(SceneManager.GetActiveScene().name == "tutorial7"){
            funcao.Instance.mao.SetActive(false);
            funcao2.Instance.mao.SetActive(false);
            funcao3.Instance.mao.SetActive(false);
            funcao4.Instance.mao.SetActive(false);
        }
        if(SceneManager.GetActiveScene().name == "tutorial2" || SceneManager.GetActiveScene().name == "tutorial5" || SceneManager.GetActiveScene().name == "tutorial6"){ 
            fase1Tutorial.Instance.maoarraste2.SetActive(false);
        }
    }
    

   
}
