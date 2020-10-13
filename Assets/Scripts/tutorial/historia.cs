using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class historia : MonoBehaviour
{
    public GameObject perso;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;
    public GameObject texto5;
    public GameObject maoarraste;
    public GameObject maoarraste2;
    public GameObject maoclick;
    public int clicou;
    public GameObject textoinicial;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Ativar());
        
    }
    void Start(){
        clicou = 0;
         StartCoroutine(dialogoInicial());
        

    }
    public IEnumerator Ativar(){
       
        if(clicou == 1){
            maoclick.SetActive(false);
            texto1.SetActive(false);
            texto2.SetActive(true);
        }
        else if(clicou ==2){
            texto2.SetActive(false);
            texto3.SetActive(true);
        }
        else if(clicou ==3){
            texto3.SetActive(false);
            texto4.SetActive(true);
            yield return new WaitForSeconds(5F);
           

        }
        else if(clicou ==4){
             SceneManager.LoadScene("tutorial2");

        }


    }
    public void proximoTutorial(){
        if(clicou >= 0 && clicou <= 3){
            clicou +=1;
            Debug.Log(clicou);
        }
      
    }
    public IEnumerator dialogoInicial(){
        yield return new WaitForSeconds(0.5F);
        perso.SetActive(true);
        yield return new WaitForSeconds(0.5F);
        texto1.SetActive(true);
        yield return new WaitForSeconds(3F);
        maoclick.SetActive(true);
    }
}
