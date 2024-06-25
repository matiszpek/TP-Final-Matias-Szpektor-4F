using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public int selected=0;
    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<objetos.Length;i++)
        {
            objetos[i].SetActive(false);
        }
        objetos[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {   
            objetos[selected].SetActive(false);
            selected++;
            if(selected>objetos.Length-1){objetos[objetos.Length-1].SetActive(true);}
            else{objetos[selected].SetActive(true);}
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[selected].SetActive(false);
            selected--;
            if(selected<0){objetos[0].SetActive(true);}
            else{objetos[selected].SetActive(true);}
        }

    }
}
