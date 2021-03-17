using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length;
    private float startpos;
    public float Efectoparallax;
   
   
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        
            
    }

    
    void Update()
    {
        float temp = (Camera.main.transform.position.x * (1 - Efectoparallax));
        float dist = (Camera.main.transform.position.x * Efectoparallax);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if(temp > startpos + length)
        {
            startpos += length;
        }
        else if (temp <startpos-length)
        {
            startpos -= length;
        }

    }
  
}
