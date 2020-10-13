using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public  class movimento : MonoBehaviour{

	public static movimento Instance;
	private Rigidbody2D personagem;
	public Animator personagemNova;
	public static bool grounded;
	public  static Vector3 posicaoinicial;
	public Vector2 andar;
	public static bool subir;
	public static bool descer;
	public bool plataform;
	[HideInInspector]
	public bool escada = false;
	public float velocidaEscada = 0.2f;
	[HideInInspector]
	public bool usandoEscada = false;
	public float exitHop =3f;
	BoxCollider2D colisor;	
	public  Vector3 end;
	public Text vidaSemente;
	public Animator SementeAnim;
	public int semente;
	public static  List<GameObject> sementeComida = new List<GameObject>();
	public Vector3 posicaoChao;
	public AudioClip somAndar;
	public AudioClip somPular;
	public AudioClip somComer;
	public AudioClip somMorrer;
	public AudioClip somCair;
	public AudioClip somVitoria;
	public AudioClip somSubir;
	private AudioSource audioSource;
	public static bool limite = false;
	public bool dormindo;

	void Awake(){
    	Instance = this;
	} 
	void Update(){
		

	}
	public IEnumerator Start() {
		personagem = GetComponent<Rigidbody2D> ();
		colisor = GetComponent<BoxCollider2D> ();
		posicaoinicial = personagem.transform.position;
		vidaSemente.text = semente.ToString();
		audioSource = GetComponent<AudioSource>(); 
		yield return new WaitForSeconds(1.5F);
		GetComponent<Animator>().SetBool("aparecendo", true); 
		menu.Cena = gameObject.scene.buildIndex;
		
	}
	
	public IEnumerator Andando(){
	
		Sons(somAndar);
		GetComponent<Animator>().SetBool("andando", true);
		yield return new WaitForSeconds(0.20F);
        end = transform.position + new Vector3(0.93f,0f,0f);
        float distancia = (transform.position - end).sqrMagnitude;
        while(distancia > float.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, end, 1.5f * Time.deltaTime);
            distancia = (transform.position - end).sqrMagnitude;  
            yield return null;
				
        }
		yield return new WaitForSeconds(0.1F);
		if(grounded){
			tilemap.Instance.PintarTile();
		}
		if(plataform && tilemapPlataforma.plataforma.enabled){
			tilemapPlataforma.Instance.PintarPlataforma();
		}
		GetComponent<Animator>().SetBool("andando", false);
    }

    public IEnumerator Pular(){		
        Vector3 pulo = new Vector3(0.93f,0f,0f);
        personagem.AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        personagem.AddForce(pulo*2, ForceMode2D.Impulse);
		Sons(somPular);  
		GetComponent<Animator>().SetBool("pulando", true);
		yield return new WaitForSeconds(1F);
        yield return null; 
		GetComponent<Animator>().SetBool("pulando", false);  
		StartCoroutine(tilemap.Instance.PintarTilePulo());
		if(plataform && tilemapPlataforma.plataforma.enabled){
			StartCoroutine(tilemapPlataforma.Instance.PintarPlataformaPulo());
		}
		
    }
	public IEnumerator morrer(){
		yield return new WaitForSeconds(1.5F);
		Play.Instance.renderSprite.sprite = Play.Instance.PlayElevado;
		transform.position = posicaoinicial;
		 if(tilemapPlataforma.plataforma){
			 tilemapPlataforma.plataforma.enabled = false;
		 }
		resetSementes();
		Play.Instance.chao.SwapTile (Play.Instance.newTile,Play.Instance.Mytile);
		if(tilemapPlataforma.plataforma){
			tilemapPlataforma.Instance.myTileMap.SwapTile(Play.Instance.newTilePlataforma, Play.Instance.MytilePlataforma);
		}
		GetComponent<Animator>().SetBool("andando", false);
		GetComponent<Animator>().SetBool("morrendo", false);
	}

	public void resetSementes(){
		if(sementeComida != null){
			foreach(var s in sementeComida){
				s.SetActive(true);	
				semente = 0;
				vidaSemente.text = semente.ToString();
			}
		}
		if(gameObject.scene.name == "Fase 3" || gameObject.scene.name == "Fase 6" ){
			objectoEspecial.Instance.objecto.SetBool("ativo", false);
			objectoEspecial.Instance.gameObject.SetActive(true);
			if(gameObject.scene.name == "Fase 6"){
		
			}
		}
	}
	void Sons(AudioClip audioClip){
		audioSource.clip = audioClip;
		audioSource.Play();  
	}
    void OnCollisionStay2D(Collision2D col){
	
		if(col.gameObject.tag == "chao"){
			grounded = true;
			posicaoChao = col.transform.position;
			GetComponent<Animator>().SetBool("descer", false); 

		}
		if(col.gameObject.tag == "plataforma"){
			plataform =  true;
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
			tilemapPlataforma.plataforma.enabled= false;
		}
	}
	public IEnumerator Subir(){
		personagem.velocity = new Vector2(personagem.velocity.x, velocidaEscada);
		personagem.gravityScale = 0;
		escada = true;
		Sons(somSubir);
		GetComponent<Animator>().SetBool("subir", true);
		plataform = true;
		tilemapPlataforma.plataforma.enabled = true;
		yield return new WaitForSeconds(0.8F);
		if(plataform && tilemapPlataforma.plataforma.enabled){
			StartCoroutine(tilemapPlataforma.Instance.PintarPlataformaPulo());
		}
	}
	public IEnumerator Descer(){
		personagem.gravityScale = 1;
		escada = false;
		tilemapPlataforma.plataforma.enabled = false;
		personagem.velocity = new Vector2(personagem.velocity.x,0);
		Sons(somSubir);
		Debug.Log("estou no descer");
		GetComponent<Animator>().SetBool("descer", true);
		grounded = true;
		yield return new WaitForSeconds(0.8F);
		if(grounded){
			tilemap.Instance.PintarTile();
		}
	}
	void OnTriggerExit2D(Collider2D ext){
		subir = false;
		GetComponent<Animator>().SetBool("subir", false);  
		if(ext.gameObject.tag == "escada" && escada){
			descer = true;
			personagem.gravityScale = 1;
			tilemapPlataforma.plataforma.enabled = true;
		}
	}
	  public IEnumerator OnTriggerEnter2D (Collider2D Obj){
		if(Obj.gameObject.tag == "semente"){
			Obj.gameObject.SetActive(false);
			GetComponent<Animator>().SetBool("comendo", true);
			yield return new WaitForSeconds(0.5F);
			Sons(somComer);
			yield return new WaitForSeconds(0.2F);
			sementeComida.Add(Obj.gameObject); 
			semente ++;
			SementeAnim.SetBool("QtdSemente", true);
			vidaSemente.text = semente.ToString();
			yield return new WaitForSeconds(0.2F);
        	yield return null;
			SementeAnim.SetBool("QtdSemente", false);
			GetComponent<Animator>().SetBool("comendo", false);

		}
		else if(Obj.gameObject.tag == "cobra"){
			execucao.executando = false;
			Sons(somMorrer);
			GetComponent<Animator>().SetBool("morrendo", true);
			StartCoroutine(vidas.Instance.DiminuirVidas());
			StartCoroutine(morrer());
		}
		else if(Obj.gameObject.tag == "limitePlataforma"){
			limite = true;
			execucao.executando = false;
			tilemapPlataforma.plataforma.enabled = false;
			GetComponent<Animator>().SetBool("morrendo", true);
			yield return new WaitForSeconds(0.2F);
			Sons(somCair);
			StartCoroutine(vidas.Instance.DiminuirVidas());
			StartCoroutine(morrer());
			
		
		}
	
		else if(Obj.gameObject.tag == "bandeira"){
			if(Obj.gameObject.name == "bandeira"){
				yield return new WaitForSeconds(2F);
				Sons(somVitoria);
				GetComponent<Animator>().SetBool("vitoria", true);
			}
			
			if(Obj.gameObject.name=="personagemnova" || Obj.gameObject.name=="personagemnovo"){
				Debug.Log(objectoEspecial.Instance.objectoFinal);
				if(objectoEspecial.Instance.objectoFinal){
					personagemNova.SetBool("feliz", true);
					Sons(somVitoria);
					GetComponent<Animator>().SetBool("vitoria", true);
					Debug.Log("estou aqui na vitoria");
					yield return new WaitForSeconds(2F);
					passandoFase.Instance.vitoria.SetActive(true);
					
					if(SceneManager.GetActiveScene().name == "Fase 9"){
						yield return new WaitForSeconds(6F);
						 SceneManager.LoadScene("Menu");
					}
					musica.audioBackground.volume = 0f;
					objectoEspecial.Instance.falha.SetActive(false);
					
				}
				else{
					Debug.Log("estou no else de personagem novo");
					objectoEspecial.Instance.falha.SetActive(true);
				}

			}
			else{
				passandoFase.Instance.vitoria.SetActive(false);
				musica.audioBackground.volume = 0.23f;
			}

		}
	}
}
