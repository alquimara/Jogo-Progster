using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade;
	public Vector2 posiçao;
	private Rigidbody2D personagem;
	public float velocidadeY;

	// Use this for initialization
	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.Translate (Vector2.right * velocidade * posiçao.x * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			personagem.AddForce (transform.up * velocidadeY );

		
		
		}
	}
	void OnTriggerEnter2D (Collider2D Obj){
		if(Obj.gameObject.tag == "semente"){
			Destroy (Obj.gameObject);
		}
			
		}
}
