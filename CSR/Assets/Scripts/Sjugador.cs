using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sjugador : MonoBehaviour
{

    public int puntos;
	public Rigidbody2D rbd;
	static float maxSteel = 13f;

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("moneda"))
        {
            other.gameObject.SetActive(false);
            puntos++;
        }
    }
}
