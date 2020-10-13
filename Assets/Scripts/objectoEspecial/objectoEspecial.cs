using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectoEspecial : MonoBehaviour
{
    public Animator objecto;
    public static objectoEspecial Instance;
    public bool objectoFinal = false;
    public GameObject falha;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        
    }
    void  OnTriggerEnter2D(Collider2D Obj){
        if( Obj.gameObject.tag == "personagem"){
			gameObject.SetActive(false);
            objectoFinal = true;
            objecto.SetBool("ativo", true);
          
		}
        else{
            objectoFinal = false;
            Debug.Log(objectoFinal);

        }

    }
    	
    // Update is called once per frame
    void Update()
    {
        
    }
}
