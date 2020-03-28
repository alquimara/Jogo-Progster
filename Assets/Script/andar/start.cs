using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
  public static start Instance;
    
    void Awake(){
    Instance = this;
  }

    void OnMouseDown(){
      StartCoroutine(execucao.Instance.Executar2());
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
