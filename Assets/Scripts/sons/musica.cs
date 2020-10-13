using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    public static musica Instance;
    public  static AudioSource audioBackground;
    void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        // else{
        //     Destroy(gameObject);
        // }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        audioBackground = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
