using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour{

	private Vector2 pos1 = new Vector2(2.9F,0.3f);
    private Vector2 pos2 = new Vector2(2.6F,0.3f);
    public float speed = 5.0f;

    void Update(){
        transform.position = Vector2.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
    }
}