using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactwithme : MonoBehaviour
{    
    public GameObject keepobject;

    public GameObject clone;
    public Cart find;
    void Start()
    {
    keepobject = GameObject.Find("Movetoward");
   
    }
    void OnMouseDown()
    {
        Cart find = GameObject.Find("Kiosk").GetComponent<Cart>();
        clone =Instantiate(this.gameObject);
        
        clone.transform.position = keepobject.transform.position+ new Vector3(0,0.5f,0);
        Debug.Log("Chcekcing"+this.GetComponent<definevalues>().nametag);
        find.Search(this.GetComponent<definevalues>().nametag, this.GetComponent<definevalues>().ID);
        Destroy(clone.gameObject,1.0f);



    }
       
    
}
