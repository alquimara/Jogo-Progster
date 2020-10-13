using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public Transform portal2;
    // Start is called before the first frame update
   IEnumerator OnTriggerEnter2D(Collider2D Obj){
        if(Obj.gameObject.tag == "personagem"){
            Debug.Log(movimento.Instance.plataform);
             tilemapPlataforma.plataforma.enabled = true;
             movimento.Instance.plataform = true;
            yield return new WaitForSeconds(0.5F);
            Obj.gameObject.transform.position = portal2.position;
		if(movimento.Instance.plataform && tilemapPlataforma.plataforma.enabled){
			StartCoroutine(tilemapPlataforma.Instance.PintarPlataformaPulo());
		}
           
		}

    }
    void OnTriggerExit2D(Collider2D Obj){
        if(Obj.gameObject.tag == "personagem"){
             tilemapPlataforma.plataforma.enabled = true;
             movimento.Instance.plataform = true;
        }
    }

}
