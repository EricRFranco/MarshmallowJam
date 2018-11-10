using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : Player {

    public override void Awake()
    {
        base.Awake();
        this.inputs = new KeyCode[]{ KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        base.Update();
	}
}
