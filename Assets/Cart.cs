using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Cart : MonoBehaviour
{
    public ListGenerate cart;
    float Sum = 0;
    float singleitemsum = 0;
    int DisplayID;
    string DisplayName;
    float DisplayPrice;
    public GameObject Display;
    List<Displayme> displaylist = new List<Displayme>();

    public void Search(string nametag,int ID)
    {
       
            DisplayID= cart.list.Find(e => e.ID == ID).ID;
            DisplayName =cart.list.Find(e => e.Name == nametag).Name;
            DisplayPrice=cart.list.Find(e => e.Name == nametag).Price;
            Sum = 0;//Sum + DisplayPrice;
            DisplayCartData(DisplayID,DisplayName, DisplayPrice);
               
    }
    void DisplayCartData(int id, string name , float price)
    {
        int count = 1;

        if(displaylist.Count == 0)
        {
            displaylist.Add(new Displayme(id, name, price, count));

        }
        else
        {

        
            //string hello = displaylist.Find(e => e.Nametodisplay == name);
            //int hello2 = displaylist.Find(e => e.IDdonotshow == id).IDdonotshow;
            //Debug.Log("SHOW SHOW SHOW" + displaylist.Find(e => e.Nametodisplay == name));
            try { 
                if (displaylist.Find(e => e.Nametodisplay == name).Nametodisplay == name && displaylist.Find(e => e.IDdonotshow == id).IDdonotshow == id)
                {
                    count = displaylist.Find(e => e.Nametodisplay == name).CountofItems + 1;
                    displaylist.Find(e => e.Nametodisplay == name).CountofItems = count;

                }
                else
                {
                    displaylist.Add(new Displayme(id,name, price, count));
                }
            }

            catch(Exception e)
            {
                displaylist.Add(new Displayme(id, name, price, count));
            }
        }
        PrintDisplayCart();
       
       
    }

    void PrintDisplayCart()
    {
       string Textmeshprodisplay;
        
        //sum the cart 
        foreach ( Displayme e in displaylist)
        {
            singleitemsum = e.Pricetodisplay * e.CountofItems;
            Sum = Sum + singleitemsum;
        }

        Textmeshprodisplay = "The items are as follows :\n Name   Count  IDPrice   Total \n ".Replace("\n",
                                                         Environment.NewLine);
        
        Debug.Log("The items are as follows:");
        foreach (Displayme e in displaylist)
        {
            Textmeshprodisplay += e.Nametodisplay+"    "+ e.CountofItems + "  "+ e.Pricetodisplay + "   "+ e.Pricetodisplay * e.CountofItems + "\n";
           Debug.Log(":Name:" + e.Nametodisplay + ": Count:" + e.CountofItems + ":Price of one item: " + e.Pricetodisplay + "Total Price: " + e.Pricetodisplay * e.CountofItems);
        }
        Textmeshprodisplay += "Total Amout to pay  ::" + Sum;
        Debug.Log("Amount to pay ::" + Sum);



        Display.GetComponent<TextMeshPro>().text= Textmeshprodisplay;


    }
}


 class Displayme
{
    public float Pricetodisplay;
    public string Nametodisplay;
    public int CountofItems;
    public int IDdonotshow ;
    public Displayme( int id, string name, float price, int count)
    {

        Nametodisplay = name;
        Pricetodisplay = price;
        CountofItems = count;
        IDdonotshow = id;
    }
}