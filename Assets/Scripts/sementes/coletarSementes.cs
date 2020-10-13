using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coletarSementes : MonoBehaviour
{
    public Text vidaSemente;
	public int semente;
    public Animator SementeAnim;
    public static coletarSementes Instance;
    void Awake(){
    	Instance = this;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        vidaSemente.text = semente.ToString();
        
    }
    void OnTriggerEnter2D (Collider2D Obj){
		if(Obj.gameObject.tag == "personagem"){
            Destroy(gameObject);
			semente ++;
            SementeAnim.SetBool("QtdSemente", true);
			vidaSemente.text = semente.ToString(); 
		}
    }
    void OnTriggerExit2D (Collider2D Obj){
        if(Obj.gameObject.tag == "personagem"){
            SementeAnim.SetBool("QtdSemente", false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
