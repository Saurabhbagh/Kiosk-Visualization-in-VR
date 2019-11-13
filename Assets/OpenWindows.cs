using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindows : MonoBehaviour
{
   

    public GameObject endpoint1;
    public GameObject endpoint2;
    public GameObject startpoint1;
    public GameObject startpoint2;

    public float speed = 0.001f;
    
    private float startTime;
    private float journeyLength;
    private float journeyLength2;

   
    void Start()
    {

        startTime = Time.time;

        
        journeyLength = Vector3.Distance(startpoint1.transform.position, endpoint1.transform.position);
        journeyLength2 = Vector3.Distance(startpoint2.transform.position, endpoint2.transform.position);
    }


    // Update is called once per frame
    void Update()
    {
       
        float distCovered = (Time.time - startTime) * speed;

        
        float fractionOfJourney = distCovered / journeyLength;

       
        startpoint1.transform.position = Vector3.Lerp(startpoint1.transform.position, endpoint1.transform.position, fractionOfJourney);
        startpoint2.transform.position = Vector3.Lerp(startpoint2.transform.position, endpoint2.transform.position, fractionOfJourney);

    

    }

   

    
}
