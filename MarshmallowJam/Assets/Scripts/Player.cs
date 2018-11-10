using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;
    Rigidbody2D rb;
    public KeyCode[] inputs;

    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	public void Update () {
        MovePlayer();
	}

    void MovePlayer()
    {
        Vector2 move = rb.velocity;
        if(Input.GetKey(inputs[3])) //D key
        {
           move = Vector2.right * speed;
        }
        else if(Input.GetKey(inputs[1]))
        {
            move = Vector2.right * speed * -1f;
        }
        else
        {
            move = Vector2.zero;
        }
        move.y = rb.velocity.y;
        rb.velocity = move;
    }
}
