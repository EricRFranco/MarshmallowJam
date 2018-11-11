using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    [SerializeField]
    private float speed;
    private bool player1pickup;//player1 picking up
    private bool player2pickup; // player2 pickup up
    Rigidbody2D rb;
    private float player1refresh;
    private float player2refresh;
    public KeyCode[] inputs;
    public float maxRefresh;

    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Use this for initialization
    void Start () {
        player1pickup = false;
        player2pickup = false;
        player1refresh = 0f;
        player2refresh = 0f;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
    //Keys: 0 = Up, 1 = Left, 2 = Down, 3 = Right, 4 = Throw, 5 = Consent
	public void Update () {
        MovePlayer();
        ThrowFriend();
        player1refresh += Time.deltaTime;
        player2refresh = +Time.deltaTime;
        //print("Player1Refresh =" + player1refresh + "Player2Refresh =" + player2refresh);
        
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
    void ThrowFriend()
    {
        if (Input.GetKey(inputs[4])) //picking up code
        {
            if(Input.GetKeyDown(KeyCode.Q) == true && player2pickup ==false && player2pickup != true && player1refresh >= maxRefresh) //if player 1 picks up player 2
            {
                GameObject lifted = GameObject.FindGameObjectWithTag("Player2");
                //GameObject lifter = GameObject.FindGameObjectWithTag("Player1");
                GameObject point = GameObject.FindGameObjectWithTag("Player1_Pickup");
                lifted.transform.position = point.transform.position;
                player1pickup = true;
                player2pickup = false;
                player1refresh = 0f;

            }else if(Input.GetKeyDown(KeyCode.RightControl) == true && player1pickup == false && player1pickup != true && player2refresh >= maxRefresh) //if player 2 picks up player 1
            {
                GameObject lifted = GameObject.FindGameObjectWithTag("Player1");
                //GameObject lifter = GameObject.FindGameObjectWithTag("Player1");
                GameObject point = GameObject.FindGameObjectWithTag("Player2_Pickup");
                lifted.transform.position = point.transform.position;
                player2pickup = true;
                player1pickup = false;
                player2refresh = 0f;
            }
        }
    }
}
