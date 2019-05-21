using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMov : MonoBehaviour
{

    Material mat;
    Vector2 offset;

    public int velX, velY;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(velX, velY);
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += offset * Time.deltaTime;
    }
}
