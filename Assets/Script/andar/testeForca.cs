using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeForca : MonoBehaviour
{
    public float hopHeight = 1.25f;
     private bool hopping = false;
     
     void Update() {
         if (Input.GetMouseButtonDown(0)) {
             Debug.Log(Vector2.right);
             Vector2 pos = Vector2.right* 1.45F;
             Debug.Log(pos);
             StartCoroutine(Hop(pos, 0.75f));
         }
     }
     
     IEnumerator Hop(Vector2 dest, float time) {
         if (hopping) yield break;
         
         hopping = true;
         var startPos = transform.position;
         var timer = 0.0f;
         
         while (timer <= 1.0f) {
             var height = Mathf.Sin(Mathf.PI * timer) * hopHeight;
             transform.position = Vector2.Lerp(startPos, dest, timer) + Vector2.up * height; 
             
             timer += Time.deltaTime / time;
             yield return null;
         }
         hopping = false;
     }
}
