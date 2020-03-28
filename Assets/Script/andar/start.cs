using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour{
    
    public static start Instance;
    public GameObject personagem;

    public static int play = 0;

    void Awake(){
        Instance = this;
    }

    void OnMouseDown(){
        if(play == 0){
            play = 1;
            if(personagem.transform.position != movimento.posicaoinicial){
                StartCoroutine(SetPosition());
            }
            StartCoroutine(execucao.Instance.Executar2());
        }
    }
    IEnumerator SetPosition(){
        personagem.transform.position = movimento.posicaoinicial;
        yield return new WaitForSeconds(0.5F);
    }
}
