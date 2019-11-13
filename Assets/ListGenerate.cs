using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ListGenerate : MonoBehaviour
{
    public int count = 0;
   
    public ArrayList materiallist = new ArrayList();
    public List<IDvalue> list= new List<IDvalue>();
    //IDvalue tostore = new IDvalue();
    //IDvalue tostore2 = new IDvalue();
    void Start()
    {
        addtolist();  
    }

    public void addtolist()
    {
       
        
        foreach (Transform child in transform)
        {
            count = count + 1;
            Debug.Log("Count is " + count);
            Debug.Log("name is " + child.name);
            definevalues obj = child.GetComponent<definevalues>();
            //tostore.ID = obj.ID;
            //tostore.Name = child.name;
            //tostore.Price = obj.price;
            materiallist.Add(count);
            list.Add(new IDvalue(obj.ID, obj.price, child.name));
            Debug.Log("Elements in the list  " + list.Count);
        }
        
        foreach (IDvalue e in list )
        {

            Debug.Log(" the values in the list are as follows: ID  " + e.ID + " Name: " + e.Name + " Price :" + e.Price);
        }
        //foreach (var  e in materiallist)
        //{
        //
        //    Debug.Log(" the values in the list are as follows: ID  " +e);
        //}
    }

}
