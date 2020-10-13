using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    private Rigidbody2D personagem;
    public Transform perso2;
    public Vector3 andar;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        personagem = GetComponent<Rigidbody2D> ();
        movePoint.parent = null;
        Debug.Log(transform.position);
        Debug.Log(movePoint.position + "POINT");
        
    }
    public IEnumerator Andando(){
        float distancia = (transform.position - movePoint.position).sqrMagnitude;
        while(distancia > float.Epsilon){
            andar = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);
            personagem.MovePosition(andar);
            distancia = (transform.position - movePoint.position).sqrMagnitude;
             yield return null;
    }
        }

       

    public void Andar(Vector3 p){
        while(transform.position != p){
           transform.position = Vector3.MoveTowards(transform.position, p,speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, movePoint.position,speed * Time.deltaTime);
        
       if(Vector3.Distance(transform.position, movePoint.position) <= 1.17f){
            if(Input.GetKeyDown(KeyCode.D)){
                movePoint.position += new Vector3(1.17f,0f,0f);
               Andar(movePoint.position);
                Debug.Log(movePoint.position + "POINT");
            }  
    
        }
        
    }
}
