using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour{

	public Vector2 pos1;
    public Vector2 pos2;
    public float speed = 2.0f;

    void Update(){
       transform.position = Vector2.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
    }
    void Start(){
        Debug.Log(transform.position.x);
    }
}