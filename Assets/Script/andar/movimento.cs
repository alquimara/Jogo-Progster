using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class movimento : MonoBehaviour{

	public static movimento Instance;
    public float velocidade;
	public float posicao;
	private Rigidbody2D personagem;
	public float jumpPower;
	private bool jump;
	public static bool grounded;
	public GameObject other;
	public  static Vector3 posicaoinicial;
	public Vector2 andar;
	

	void Awake(){
    	Instance = this;
	}

	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		andar = Vector2.right* 1.45F;
		posicaoinicial = personagem.transform.position;

	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			Pular();
		}
	}
	void FixedUpdate(){
		
	}

	public void Andar(){
		transform.Translate(andar);
		//personagem.AddForce(Vector2.right * 3.5f, ForceMode2D.Impulse);
		Debug.Log(transform.position.x);
	}
	public void Pular(){
		personagem.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
		personagem.AddForce(andar * 2, ForceMode2D.Impulse);
		Debug.Log(transform.position);

	}
	
    void OnCollisionStay2D(Collision2D col){
		if(col.gameObject.tag == "chão"){
			grounded = true;
		}

	}
	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.tag == "chão"){
			grounded = false;
		}
	}

	void OnTriggerEnter2D (Collider2D Obj){
		if(Obj.gameObject.tag == "semente"){
			Destroy (Obj.gameObject);
		}
		if(Obj.gameObject.tag == "cobra"){
			Destroy(other);	
			SceneManager.LoadScene("game over");
		}
	}	
}
