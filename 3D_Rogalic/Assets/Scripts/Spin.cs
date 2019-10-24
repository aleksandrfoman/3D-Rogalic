using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    public float speed = 3f;
    
    void Update()
    {
        transform.Rotate(0,speed,0);
        
    }
}
