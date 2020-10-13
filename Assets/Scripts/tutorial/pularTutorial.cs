using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pularTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void pular(){
        SceneManager.LoadScene("Mundos"); 
    }
    public void fase1 (){
         SceneManager.LoadScene("Fase 1"); 
    }
    public void fase4(){
         SceneManager.LoadScene("Fase 4");
    }
    public void fase7(){
        SceneManager.LoadScene("Fase 7");
    }
}
