using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmovimientoJugador : MonoBehaviour
{


	public Rigidbody2D rbd;
	static float maxSteel = 13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((rbd.velocity.magnitude) <= maxSteel)
        {
            if (rbd.velocity.y < 0)
            {
                rbd.AddForce(new Vector2(0,-10));
            }
            if (rbd.velocity.y < 0)
            {
                rbd.AddForce(new Vector2(0, 10));
            }
        }
            if (Input.GetKey("space")){
        	rbd.AddForce(new Vector2(0,75));
        }
    }
}
