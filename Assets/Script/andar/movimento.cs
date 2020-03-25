using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class movimento : MonoBehaviour
{
	public static movimento Instance;
    // Start is called before the first frame update
    public float velocidade;
	public float posicao;
	private Rigidbody2D personagem;
	public float velocidadeY;
	public GameObject other;
	public Vector2 posicaoinicial;
	public Vector2 andar;
 	public static List<string> acoes = new List<string>();
	public static List<string> R1 = new List<string>();
	 
	 void Awake(){
    Instance = this;
  }

	// Use this for initialization

	void Start () {
		personagem = GetComponent<Rigidbody2D> ();
		andar = Vector2.right* 1.45F;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.R)) {
			R1.Add("andar");
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			acoes.Add("R1");
		}
		/*if (Input.GetKeyDown (KeyCode.Space)) {
			personagem.AddForce (transform.up * 5 );
		}*/
	}

	public void Andar(){
		transform.Translate(andar);
	}

	public IEnumerator Executar(){
		yield return new WaitForSeconds(0.5F);
		foreach(string a in acoes){
			if(a == "andar"){
				Andar();
			}
			else if(a == "R1"){
				for(int i=0;i<contador.Instance.contadorR1;i++){
					foreach(string r in R1){
						if(r == "andar"){
							Andar();
						}
						yield return new WaitForSeconds(0.5F);
					}
				}
			}
			yield return new WaitForSeconds(0.5F);
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
