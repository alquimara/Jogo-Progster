using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class funcao4 : MonoBehaviour, IDropHandler
{
    public static funcao4 Instance;
    public GameObject mao;
    public GameObject texto;
    void Awake(){
        Instance = this;
    }
     public void OnDrop(PointerEventData eventData){
        StartCoroutine(maoPlayRepetcao());
     }

     public IEnumerator maoPlayRepetcao(){
        funcao2.Instance.texto.SetActive(false);
        funcao3.Instance.texto.SetActive(false);
        texto.SetActive(true);
        yield return new WaitForSeconds(2F);
        mao.SetActive(true);
        yield return new WaitForSeconds(3F);
        mao.SetActive(false);

    }
    
    
}
