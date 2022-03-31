using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxmin : MonoBehaviour
{
    private bool a, b, c, d;

    // Start is called before the first frame update
    void Start()
    {
       a = true;
       b = false;

       c = a && b; // f
       print(c);
       d = a||b; //t
       print(d);
       c = !c; //t
       print(c);
       a = (b&&c) || (b&&d); // f
       print(a);
       d = (a||b) && (b||c); //f
       print(d);
       b = !a && !(c||d); //f 
       print(b);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
