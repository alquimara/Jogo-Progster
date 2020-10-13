using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropTutorial : MonoBehaviour,IDropHandler
{
    public static dropTutorial Instance;
    
    void Awake(){
        Instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnDrop(PointerEventData eventData){
        fase1Tutorial.Instance.maoarraste2.SetActive(true);
        StartCoroutine(tempo());
       
        
}
public IEnumerator tempo(){
    yield return new WaitForSeconds(3F);
     fase1Tutorial.Instance.maoarraste2.SetActive(false);
}
}
