using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vidas : MonoBehaviour{
    public static vidas Instance;
    public Sprite comVida;
    public Sprite semVida;
    public Image renderVida; 
    public static  List<Image> vidasSprite;
    public static int vida;
    public static List<Animator> VidaAnim;
    public GameObject gameOverPanel;
    public bool gameOver;
    
    void Awake(){
        Instance = this;
        vida = 3;
	}

    // Start is called before the first frame update
    void Start(){
        // PlayerPrefs.DeleteAll();
        if(PlayerPrefs.HasKey("vida")){
            vida = PlayerPrefs.GetInt("vida");
        }else{
            PlayerPrefs.SetInt("vida", vida);
        }

        vidasSprite = new List<Image>();
        VidaAnim = new List<Animator>();
        foreach( Transform t in transform){
            vidasSprite.Add(t.GetComponent<Image>());
        }
    }

    public void SetarVidas(){
        if(vida < 1){
            vidasSprite[0].sprite = semVida;
        }
        if(vida >= 1){
            vidasSprite[0].sprite = comVida;
            vidasSprite[1].sprite = semVida;
            vidasSprite[2].sprite = semVida;

        }
        if(vida >= 2){
            vidasSprite[1].sprite = comVida;
            vidasSprite[2].sprite = semVida;
        }
        if(vida == 3){
            vidasSprite[2].sprite = comVida;
        }
    }

    public void ganharVida(int quantidaSemente){
        if(quantidaSemente == 3 && vida < 3){
            vida += 1;
            PlayerPrefs.SetInt("vida", vida);
        }


    }

    public  IEnumerator DiminuirVidas(){
        if(vida >= 0 && vida <= 3){
            yield return new WaitForSeconds(0.001F);
            vida -= 1;
            PlayerPrefs.SetInt("vida", vida);

        }
    }
    public void GameOver(){
        if(vida < 1){
            movimento.Instance.gameObject.SetActive(false);
            gameOverPanel.SetActive(true);
            musica.audioBackground.volume = 0f;
            
            // SceneManager.LoadScene("Game Over");
        }
        else{
            gameOverPanel.SetActive(false);
            musica.audioBackground.volume = 0.05f;
            
        }
    }

    // Update is called once per frame
    void Update(){
        SetarVidas(); 
        GameOver();      
    }
}
