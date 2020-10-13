using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class tilemapPlataformaDinamica : MonoBehaviour
{
    public TilemapCollider2D plataformaDinamica;
    public Tilemap myTileMap;
    public static tilemapPlataformaDinamica Instance;
    // Start is called before the first frame update
    void Awake(){
        Instance = this;
    }
    void Start(){
    }

    void Update()
    {
        if(Play.play == 1){
            Vector3Int inicial = new Vector3Int(3,3,0);
            myTileMap.SetTile(inicial,null);
            // botaoChave.Instance.plataformaDinamica.SetBool("dinamica", false);
        }
        
    }
}
