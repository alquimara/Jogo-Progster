using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class contadorPecas : MonoBehaviour
{
    public Transform[] obj;
    public Text quantidade_andar;
    public Text quantidade_pular;
    public Text quantidade_subir;
    public Text quantidade_descer;
    public Text quantidade_f1;
    public Text quantidade_f2;
    

    public static contadorPecas Instance;
    void Awake(){
        Instance = this;
        //obj = GetComponentsInChildren<Transform>(true);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
         foreach (Transform t in transform.parent) {
                if(t.tag == "peca_andar"){
                    quantidade_andar.text = t.childCount.ToString();
                }
                if(t.tag =="peca_pular"){
                    quantidade_pular.text = t.childCount.ToString();
                }
                 if(t.tag =="peca_subir"){
                    quantidade_subir.text = t.childCount.ToString();
                }
                 if(t.tag =="peca_descer"){
                    quantidade_descer.text = t.childCount.ToString();
                }
                 if(t.tag =="peca_f1"){
                    quantidade_f1.text = t.childCount.ToString();
                }
                 if(t.tag =="peca_f2"){
                    quantidade_f2.text = t.childCount.ToString();
                }
                // if(t.tag == "peca_R1"){
                //     Debug.Log(t.childCount);
                // }
                
         }
    }
}
