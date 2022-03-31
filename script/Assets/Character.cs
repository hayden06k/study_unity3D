using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    int a, b, c, d;
    // Start is called before the first frame update
    void Start()
    {
        a = 10;
        b =2;
        c = a+b;
        print(a.ToStrig() + "+" b.ToString() "=" c.ToString());
        d = a-b;
        print(a.ToString() + "-" b.ToString() "=" d.ToString());
        c = a/b;
        print(a.ToStrig() + "/" b.ToString() "=" c.ToString());
        d = a%b;
        print(a.ToStrig() + "%" b.ToString() "=" d.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
