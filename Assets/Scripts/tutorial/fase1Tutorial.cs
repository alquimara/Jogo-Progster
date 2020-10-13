using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fase1Tutorial : MonoBehaviour
{
    public static fase1Tutorial Instance;
    public int clicou;
    public GameObject perso;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;
    public GameObject maoarraste;
    public GameObject maoarraste2;
    public GameObject maoclick;
    public GameObject maoclick2;
    public GameObject textoinicial;
    public GameObject maotutorial;
  
    // Start is called before the first frame update
    void Awake(){
        Instance = this;
    }
    void Start()
    {
        clicou = 0;
        if(SceneManager.GetActiveScene().name == "tutorial5"){
            movimento.descer = true;
        }
        StartCoroutine(Ativar());
        
        
    }
    void Update(){
       

    }


    // Update is called once per frame
    public IEnumerator Ativar()
    {
        if(SceneManager.GetActiveScene().name == "tutorial2" || SceneManager.GetActiveScene().name == "tutorial3" ||  SceneManager.GetActiveScene().name == "tutorial4"|| SceneManager.GetActiveScene().name == "tutorial5" || 
            SceneManager.GetActiveScene().name == "tutorial6" || SceneManager.GetActiveScene().name == "tutorial7"){
           if(clicou == 0){
                yield return new WaitForSeconds(0.5F);
                perso.SetActive(true);
                yield return new WaitForSeconds(0.5F);
                if(SceneManager.GetActiveScene().name == "tutorial2" || SceneManager.GetActiveScene().name == "tutorial6" || SceneManager.GetActiveScene().name == "tutorial7"){
                    textoinicial.SetActive(true);
                     yield return new WaitForSeconds(0.5F);
                    maotutorial.SetActive(true);
                }
                else{
                    Debug.Log("estou aqui");
                    texto1.SetActive(true);
                    yield return new WaitForSeconds(4F);
                    maoarraste.SetActive(true);
                    yield return new WaitForSeconds(3F);
                    maoarraste.SetActive(false);

                }
            }    
        }
    }
    public IEnumerator maoAtiva(){
        if(clicou == 1){
            textoinicial.SetActive(false);
            maotutorial.SetActive(false);
            texto1.SetActive(true);
            yield return new WaitForSeconds(4F);
            maoarraste.SetActive(true);
            yield return new WaitForSeconds(3F);
            maoarraste.SetActive(false);
            }
    }

    public void proximoTutorial(){
        if(clicou >= 0 && clicou <= 3){
            clicou +=1;
            Debug.Log(clicou);
        }

        StartCoroutine(maoAtiva());
        
    }
}
