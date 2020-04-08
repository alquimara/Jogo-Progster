using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public  class movimento : MonoBehaviour{

	public static movimento Instance;
	private Rigidbody2D personagem;
	public float jumpPower;
	public static bool grounded;
	public GameObject other;
	public  static Vector3 posicaoinicial;
	public Vector2 andar;
	public static bool subir;
	public static bool descer;
	public BoxCollider2D plataforma;
	[HideInInspector]
	public bool escada = false;
	public float velocidaEscada = 3f;
	[HideInInspector]
	public bool usandoEscada = false;
	public float exitHop =3f;
	BoxCollider2D colisor;
	public float moveTime = 0.1f;
    public float inverteMoveTime;
	public  Vector3 end;
	public Text vidaSemente;
	public int semente;
	

	void Awake(){
    	Instance = this;
	}

	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		colisor = GetComponent<BoxCollider2D> ();   
		posicaoinicial = personagem.transform.position;
		vidaSemente.text = semente.ToString();
	}

	void Update () {

	}
	/*public void Andar(){
		//transform.Translate(andar);
		//personagem.velocity = new Vector2(2.9f,0.5f);
		personagem.velocity = new Vector2(2.88f,0.5f);
		Debug.Log(transform.position.x);
	}
	public void Pular(){
		personagem.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
		personagem.AddForce(andar * 2, ForceMode2D.Impulse);

	}*/
	public IEnumerator Andando(){
        end = transform.position + new Vector3(0.93f,0f,0f);
        float distancia = (transform.position - end).sqrMagnitude;
        Debug.Log((transform.position - end).sqrMagnitude);
        while(distancia > float.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, end, 3 * Time.deltaTime);
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

    void OnCollisionStay2D(Collision2D col){
		if(col.gameObject.tag == "chao"){
			grounded = true;
		}
		if(col.gameObject.tag == "plataforma"){
			
		}
		
	}
	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.tag == "chao"){
			grounded = false;
		}
	}
	void OnTriggerStay2D(Collider2D esc){
		if(esc.gameObject.tag == "escada"){
			subir = true;
			Debug.Log("coledi");
		}

	}
	public void Subir(){
		personagem.velocity = new Vector2(personagem.velocity.x, velocidaEscada);
		personagem.gravityScale = 0;
		escada =true;
		plataforma.enabled = true;
		Debug.Log("aqui");
		
	}
	public void Descer(){
		personagem.gravityScale = 1;
		escada = false;
		plataforma.enabled = false;
		personagem.velocity = new Vector2(personagem.velocity.x,0);


	}
	void OnTriggerExit2D(Collider2D ext){
		if(ext.gameObject.tag == "escada" && escada){
			descer = true;
			personagem.gravityScale = 1;
		}
	}
	void OnTriggerEnter2D (Collider2D Obj){
		if(Obj.gameObject.tag == "semente"){
			Destroy(Obj.gameObject);
			semente ++;
			vidaSemente.text = semente.ToString();
		}
		else if(Obj.gameObject.tag == "cobra"){
			Destroy(Obj.gameObject);
			SceneManager.LoadScene("Game Over");
			
		}
		else if(Obj.gameObject.tag == "bandeira"){
			SceneManager.LoadScene("Vitoria");
			Debug.Log("passei rapido");
			
		}
		else if(Obj.gameObject.tag == "bandeira_2"){
			SceneManager.LoadScene("Vitoria");
			
		}
		
	}
}
