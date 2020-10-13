using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class funcao2 : MonoBehaviour, IDropHandler
{
    public static funcao2 Instance;
    public GameObject mao;
    public GameObject texto;
    void Awake(){
        Instance = this;
    }
     public void OnDrop(PointerEventData eventData){
        StartCoroutine(maoPlayRepetcao());
     }

     public IEnumerator maoPlayRepetcao(){
        fase1Tutorial.Instance.texto1.SetActive(false);
        texto.SetActive(true);
        yield return new WaitForSeconds(2F);
        mao.SetActive(true);
        yield return new WaitForSeconds(3F);
        mao.SetActive(false);

    }
    
}
