using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class tilemap : MonoBehaviour
{
    //public Grid grid; //Set a Grid or Tilemap object to this in the Editor
    public Tilemap myTileMap;
    public static tilemap Instance;
    public Tile newTile;
    public Tile Mytile;
    public bool pintando = true;
    public Vector3 worldCell;
    public GridLayout gridLayout;
    public Vector3Int coordinate;
    public Vector3Int coordinate_aux;
    public static TilemapCollider2D colisorChao;

    void Start(){
        colisorChao = GetComponent<TilemapCollider2D>();  
        colisorChao.enabled = true;
    }
    void Awake(){
        Instance = this; 
    }

    public void PintarTile(){
        worldCell = movimento.Instance.transform.position;
        gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        coordinate = gridLayout.WorldToCell(worldCell);
        coordinate.y -= 1;
        coordinate.x += 1;
        myTileMap.SetTile(coordinate, newTile);        
    }

    public IEnumerator PintarTilePulo(){
        while(!movimento.grounded || movimento.limite){
            yield return new WaitForSeconds(0.1F);
            break;
        }
        if(movimento.grounded){
               PintarTile();
            }
     
    }


    // public void PintarTilePulo(){
    //     worldCell = movimento.Instance.transform.position;
    //     gridLayout = transform.parent.GetComponentInParent<GridLayout>();
    //     coordinate = gridLayout.WorldToCell(worldCell);
    //     coordinate.y -= 1;
    //     // coordinate_aux = coordinate;
    //     // coordinate_aux.x += 3;
    //     coordinate.x += 1;
    //     myTileMap.SetTile(coordinate, newTile);
    //     // while(!movimento.grounded){
    //     //    yield return new WaitForSeconds(0.1F);
    //     //    if(movimento.grounded){
    //     //         myTileMap.SetTile(coordinate, newTile);
    //     //    }
    //     //    break;
    //     }
    
    public void Update()
    { 
      if(SceneManager.GetActiveScene().name == "tutorial5"){

      }
      else{
        Vector3Int inicial = new Vector3Int(-9,0,0);
        myTileMap.SetTile(inicial, newTile);
      }
    }
}
