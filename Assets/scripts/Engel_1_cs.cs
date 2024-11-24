using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engel_1_cs : MonoBehaviour
{
    Manager_cs manager;
     public float speed=1.0f;
     bool goRight;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager_cs>();
        transform.position = new Vector2( 7.0f , 3.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.oyunuDurdur==false){
        if(transform.position.x>=7.5f){
         goRight=false;
        }
        else if(transform.position.x<=-7.79f){
         goRight=true;
        }

        if(goRight){
         transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        else if(goRight == false){
         transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        }
    }
    



   
}
