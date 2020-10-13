using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentGrid : MonoBehaviour
{
    public static movimentGrid Instance;
    void Awake(){
        Instance = this;
    }
    public float moveTime = 0.1f;
    public float inverteMoveTime;
   
    public float speed;
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    public static Rigidbody2D personagem;
    public Transform perso2;
    public float jumpPower;
    public Vector3 andar;
    public static bool podeandar;
    public  Vector3 end;
    // Start is called before the first frame update
    void Start()
    {
        personagem = GetComponent<Rigidbody2D> ();
        //movePoint.parent = null;     
        inverteMoveTime =1f / moveTime;   
    }

    public void Andar(){
        if(Vector3.Distance(transform.position, movePoint.position) <= 0.93f){
                movePoint.position += new Vector3(0.93f,0f,0f);   
                Debug.Log(movePoint.position  + "posicao");  
        }
    }
    public IEnumerator Andando(){
        end = transform.position + new Vector3(0.93f,0f,0f);
        float distancia = (transform.position - end).sqrMagnitude;
        Debug.Log((transform.position - end).sqrMagnitude);
        while(distancia > float.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, end, inverteMoveTime * Time.deltaTime);
            Debug.Log("andando");
            distancia = (transform.position - end).sqrMagnitude;   
            yield return null;
        }
        }
    public IEnumerator Pular(){
        Vector3 pulo = new Vector3(0.93f,0f,0f);
        personagem.AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        personagem.AddForce(pulo*2, ForceMode2D.Impulse);
        Debug.Log(Vector3.up *5  + "pulando");
        yield return null;
    }

}
