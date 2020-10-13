using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class novoPlay : MonoBehaviour
{
    public GameObject botao;
    public GameObject objecto6;
    // Start is called before the first frame update

    // Update is called once per frame
    public void OnMouseDown(){
        StartCoroutine(ativarBotaoProximo());
    }
        public IEnumerator ativarBotaoProximo(){
        fase1Tutorial.Instance.maoclick.SetActive(false);
        yield return new WaitForSeconds(5F);
        // fase1Tutorial.Instance.texto4.SetActive(true);
        if(SceneManager.GetActiveScene().name == "tutorial7"){
            yield return new WaitForSeconds(12F);
            botao.SetActive(true);
            objecto6.SetActive(true);
        }
        yield return new WaitForSeconds(4F);
        botao.SetActive(true);
        objecto6.SetActive(true);
        




       




    }
    
}
