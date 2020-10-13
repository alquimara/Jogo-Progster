using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour{
    
    public static Play Instance;
    public GameObject personagem;
    public Sprite PlayApertado;
    public Sprite PlayElevado;
    public Sprite StopElevado;
    public Sprite StopApertado;
    public SpriteRenderer renderSprite; 
    public Tilemap chao;
    //public Tilemap plataforma;
    public Tile Mytile;
    public Tile newTile;
    public Tile MytilePlataforma;
    public Tile newTilePlataforma;


    public static int play = 0;

    void Awake(){
        Instance = this;
    }
    void start(){
        renderSprite = GetComponent<SpriteRenderer>();
        
    }

    IEnumerator OnMouseDown(){
        
        if(play == 0){
            renderSprite.sprite = PlayApertado;
            yield return new WaitForSeconds(0.5F);
            renderSprite.sprite = StopElevado;
            play = 1;
            if(personagem.transform.position != movimento.posicaoinicial){
                Debug.Log("estou dentro do if");
                yield return StartCoroutine(SetPosition());
            }
            yield return StartCoroutine(execucao.Instance.Executar2());
            yield return new WaitForSeconds(0.5F);
            renderSprite.sprite = PlayElevado;
            
        }
        else {
                execucao.executando = false;
                play = 0;
                renderSprite.sprite = StopApertado;
                yield return new WaitForSeconds(0.5F);
                renderSprite.sprite = PlayElevado;
                
        }
    }
    IEnumerator SetPosition(){
        personagem.transform.position = movimento.posicaoinicial;
        movimento.Instance.resetSementes();
        chao.SwapTile (newTile,Mytile);
        if(tilemapPlataforma.plataforma){
            tilemapPlataforma.plataforma.enabled = false;
            tilemapPlataforma.Instance.myTileMap.SwapTile(newTilePlataforma, MytilePlataforma);
        }
        
        yield return new WaitForSeconds(0.5F);
        
    }
}
