using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDvalue
{
    public int ID
    {
        get;
        set;

    }

    public float Price
    {
        get;
        set;

    }

    public string Name
    {

        get;
        set;
    }

    public IDvalue(int Id, float price, string Nametag)
    {

        ID = Id;
        Price = price;
        Name = Nametag;
    }

}
