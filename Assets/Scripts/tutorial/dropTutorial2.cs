using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dropTutorial2 : MonoBehaviour,IDropHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnDrop(PointerEventData eventData){
         if(SceneManager.GetActiveScene().name == "tutorial6"){
             repeticaoTutorial.Instance.texto6.SetActive(false);
         }
         if(SceneManager.GetActiveScene().name == "tutorial7"){
             funcao4.Instance.texto.SetActive(false);

         }
        fase1Tutorial.Instance.texto1.SetActive(false);
        fase1Tutorial.Instance.texto2.SetActive(true);
         StartCoroutine(maoPlay());

     }

    public IEnumerator maoPlay(){
         yield return new WaitForSeconds(1.5F);
         fase1Tutorial.Instance.maoclick.SetActive(true);
    }
}
