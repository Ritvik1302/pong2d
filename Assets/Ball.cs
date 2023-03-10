using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    private Rigidbody2D rb;
    public float speed = 100f;
    void Awake ()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        reset();
        AddStartingForce();
    }
    public void AddStartingForce()
    {
        float x = Random.value < 0.5f?-1.0f:1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1f,-0.5f):Random.Range(0.5f,1f);
        Vector2 direction=new Vector2(x,y);
        rb.AddForce(direction*speed);
    }
    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
    public void reset()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;

    }
}
