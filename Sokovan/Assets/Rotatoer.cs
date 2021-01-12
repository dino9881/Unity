using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Rotatoer : MonoBehaviour

{
    
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(60* Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
    }
}
