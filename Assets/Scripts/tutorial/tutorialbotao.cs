using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialbotao : MonoBehaviour
{
    public GameObject AtivaBoatochave;
     public GameObject AtivaBoatochave2;
    // Start is called before the first frame update
    void Start()
    {
        AtivaBoatochave.SetActive(true);
         StartCoroutine(ativar());

        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public IEnumerator ativar(){
        yield return new WaitForSeconds(5F);
        AtivaBoatochave.SetActive(false);
        AtivaBoatochave2.SetActive(true);
        yield return new WaitForSeconds(5F);
        AtivaBoatochave2.SetActive(false);
         


    }
}
