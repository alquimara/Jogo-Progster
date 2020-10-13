using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class repeticaoTutorial : MonoBehaviour, IDropHandler
{
    public static repeticaoTutorial Instance;
    public GameObject texto5;
    public GameObject mao;
    public GameObject texto6;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake(){
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrop(PointerEventData eventData){
        fase1Tutorial.Instance.texto1.SetActive(false);
        texto5.SetActive(true);
        StartCoroutine(maoPlayfuncao());
     }

     public IEnumerator maoPlayfuncao(){
         yield return new WaitForSeconds(1.5F);
         mao.SetActive(true);
         yield return new WaitForSeconds(3F);
         mao.SetActive(false);

    }
}
