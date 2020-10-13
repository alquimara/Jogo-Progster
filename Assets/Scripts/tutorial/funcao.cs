using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class funcao : MonoBehaviour, IDropHandler
{
    public static funcao Instance;
    public GameObject mao;
    public GameObject mao2;
    public GameObject texto;
    void Awake(){
        Instance = this;
    }
     public void OnDrop(PointerEventData eventData){
        StartCoroutine(maoPlayRepetcao());
        Debug.Log(gameObject.tag);
     }

     public IEnumerator maoPlayRepetcao(){
         yield return new WaitForSeconds(1.5F);
         mao.SetActive(true);
         yield return new WaitForSeconds(3F);
        mao.SetActive(false);
         if(gameObject.name == "Slot_F2_2"){
             fase1Tutorial.Instance.texto1.SetActive(false);
             texto.SetActive(true);
             yield return new WaitForSeconds(1.5F);
             mao2.SetActive(true);
             yield return new WaitForSeconds(3F);
              mao2.SetActive(false);


         }

    }
}
