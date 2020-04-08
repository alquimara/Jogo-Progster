using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour{

	public Vector2 pos1;
    public Vector2 pos2;
    public float speed = 1.5f;

    void Update(){
       transform.position = Vector2.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
    }
    void Start(){
        pos1 = transform.position;
        pos2 = pos1 + new Vector2(0.2f, 0f);
        Debug.Log(transform.position.x);
    }
}