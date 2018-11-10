using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : Player {

    public override void Awake()
    {
        base.Awake();
        this.inputs = new KeyCode[]{KeyCode.UpArrow, KeyCode.LeftArrow, KeyCode.DownArrow, KeyCode.RightArrow};
    }
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        base.Update();
	}
}
