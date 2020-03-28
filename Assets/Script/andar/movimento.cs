using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class movimento : MonoBehaviour{

	public static movimento Instance;
    public float velocidade;
	public float posicao;
	private Rigidbody2D personagem;
	public float velocidadeY;
	public GameObject other;
	public Vector2 posicaoinicial;
	public Vector2 andar;
	
	void Awake(){
    	Instance = this;
	}

	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		andar = Vector2.right* 1.45F;
	}

	/*void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			personagem.AddForce (transform.up * 5 );
		}
	}*/

	public void Andar(){
		transform.Translate(andar);
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
