using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semente : MonoBehaviour
{ public IEnumerator OnTriggerEnter2D (Collider2D Obj){
	if(Obj.gameObject.tag == "personagem"){
        fase1Tutorial.Instance.texto2.SetActive(false);
         yield return new WaitForSeconds(0.5F);
    }
}
}
