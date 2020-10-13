using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class tilemapPlataforma : MonoBehaviour
{
    public Tilemap myTileMap;
    public Tile newTile;
    public static tilemapPlataforma Instance;
    public  static TilemapCollider2D plataforma;
    public Vector3Int coordinate_aux;
    public  Vector3 worldCell;
    public GridLayout gridLayout;
    public Vector3Int coordinate;
    void Awake(){
    	Instance = this;
	}
    void Start(){
        plataforma = GetComponent<TilemapCollider2D>();
    }
    void Update(){
        if(SceneManager.GetActiveScene().name == "tutorial5"){
            Vector3Int inicial = new Vector3Int(-1,3,0);
            myTileMap.SetTile(inicial, newTile);
            Debug.Log("aqui");
        }
        else{

        }
    }

    public void PintarPlataforma() {
    if (movimento.Instance.plataform && plataforma.enabled){
        worldCell = movimento.Instance.transform.position;
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        coordinate = gridLayout.WorldToCell(worldCell);
        coordinate.y -= 3;
        myTileMap.SetTile(coordinate, newTile);
     }
     }
        
    public IEnumerator PintarPlataformaPulo(){
    worldCell = movimento.Instance.transform.position;
    gridLayout = transform.parent.GetComponentInParent<GridLayout>();
    coordinate = gridLayout.WorldToCell(worldCell);
    coordinate.y -= 3;
    while(!movimento.Instance.plataform && !plataforma.enabled){
        yield return new WaitForSeconds(0.1F);
        break;
        }
    if(movimento.Instance.plataform && plataforma.enabled){
        myTileMap.SetTile(coordinate, newTile);
    }
          
    }
}
