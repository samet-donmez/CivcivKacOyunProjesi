using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engel_2_cs : MonoBehaviour
{
    Manager_cs manager;
    public float speed=1.0f;
     bool goRight;
     bool goUp;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager_cs>();
        transform.position = new Vector2( -5.0f , -1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.oyunuDurdur==false){
        if(transform.position.x>=-2.0f){
         goRight=false;
        }
        else if(transform.position.x<=-5.86f){
         goRight=true;
        }

        if(goRight){
         transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        else if(goRight == false){
         transform.Translate(Vector2.left * Time.deltaTime * speed);
        }




         if(transform.position.y<=-4.3f){
         goUp=true;
        }
        else if(transform.position.y>=-1.0f){
         goUp=false;
        }

        if(goUp){
         transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        else if(goUp == false){
         transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
    }}
}
