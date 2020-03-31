using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour{
    
    public static Play Instance;
    public GameObject personagem;
    public Sprite PlayApertado;
    public Sprite PlayElevado;
    public SpriteRenderer renderSprite; 

    public static int play = 0;

    void Awake(){
        Instance = this;
    }
    void start(){
    renderSprite = GetComponent<SpriteRenderer>();
    }

    IEnumerator OnMouseDown(){
        renderSprite.sprite = PlayApertado;
        if(play == 0){
            play = 1;
            if(personagem.transform.position != movimento.posicaoinicial){
                yield return StartCoroutine(SetPosition());
            }
            yield return StartCoroutine(execucao.Instance.Executar2());
            renderSprite.sprite = PlayElevado;
        }
    }
    IEnumerator SetPosition(){
        personagem.transform.position = movimento.posicaoinicial;
        yield return new WaitForSeconds(0.5F);
    }
}
