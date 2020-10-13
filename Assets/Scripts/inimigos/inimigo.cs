using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour{

	public Vector2 pos1;
    public Vector2 pos2;
    public float speed = 0.5f;
    public bool plataformaDinamica;

    void Update(){
        Debug.Log(transform.position);
        
            // transform.position = Vector2.Lerp(pos1, pos2,Time.time*speed);
    } 
    void Start(){
        plataformaDinamica = false;
        pos1 = new Vector2(0.5f,0.4f);
        pos2 = new Vector2(3,3);
    }
      void OnCollisionStay2D(Collision2D plata){
          if(plata.gameObject.tag == "personagem"){
              plataformaDinamica = true;
          }
      }

}