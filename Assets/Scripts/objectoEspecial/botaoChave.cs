using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class botaoChave : MonoBehaviour
{

    public Animator botaoAtivo;
    public Animator plataformaDinamica;
    public static botaoChave Instance;
    public Tilemap myTileMap;
    public BoxCollider2D limiteEscada;

    void Awake(){
        Instance = this;
    }
    void Start()
    {
        botaoAtivo = GetComponent<Animator>();
        
    }
 public void OnTriggerEnter2D (Collider2D Obj){
     if(Obj.gameObject.tag == "personagem"){
        plataformaDinamica.SetBool("dinamica", true);
      
     }
 }
}
