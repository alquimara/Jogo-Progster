using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bandeira : MonoBehaviour
{
     public GameObject texto;
    // Start is called before the first frame update
   
    // Update is called once per frame
   void OnTriggerStay2D(Collider2D esc){
		if(esc.gameObject.tag == "personagem"){
            StartCoroutine(ativar());
            if(SceneManager.GetActiveScene().name == "tutorial5" || SceneManager.GetActiveScene().name == "tutorial6" || 
            SceneManager.GetActiveScene().name == "tutorial7") {
               StartCoroutine(ativartexto());
            }
		}
	}
     public IEnumerator ativar(){
         yield return new WaitForSeconds(1F);
          fase1Tutorial.Instance.texto4.SetActive(true);
     }
      public IEnumerator ativartexto(){
         yield return new WaitForSeconds(4F);
         fase1Tutorial.Instance.texto4.SetActive(false);
          texto.SetActive(true);
     }
}
