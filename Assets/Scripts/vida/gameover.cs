using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
   public void Restart() {
        Play.play = 0;
        movimento.sementeComida = new List<GameObject>();
        PlayerPrefs.DeleteKey("vida");

        if(SceneManager.GetActiveScene().name == "Fase 1" || SceneManager.GetActiveScene().name == "Fase 2" || SceneManager.GetActiveScene().name == "Fase 3"){
            SceneManager.LoadScene("Fase 1");
        }
        else if(SceneManager.GetActiveScene().name == "Fase 4" || SceneManager.GetActiveScene().name == "Fase 5" || SceneManager.GetActiveScene().name == "Fase 6"){
            SceneManager.LoadScene("Fase 4");
        }
        else if(SceneManager.GetActiveScene().name == "Fase 7" || SceneManager.GetActiveScene().name == "Fase 8" || SceneManager.GetActiveScene().name == "Fase 9"){
            SceneManager.LoadScene("Fase 7");
        }
    }

    public void Menu(){
        Play.play = 0;
        PlayerPrefs.DeleteKey("vida");
        SceneManager.LoadScene("Menu");
    }
}
