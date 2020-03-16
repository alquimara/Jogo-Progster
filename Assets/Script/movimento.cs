using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    	public float velocidade;
	public float posicao;
	private Rigidbody2D personagem;
	public float velocidadeY;
	public GameObject other;
	public Vector2 posicaoinicial;
	


	// Use this for initialization
	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		print(transform.position.x);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.Translate(Vector2.right* 1.45F);
			print(transform.position.x);
			


		
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			personagem.AddForce (transform.up * 5 );
			

		
		
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
