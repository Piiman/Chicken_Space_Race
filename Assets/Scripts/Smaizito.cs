using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smaizito : MonoBehaviour
{

    public Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        rbd.velocity = new Vector2(-5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
