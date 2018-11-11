using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSpin : MonoBehaviour
{
    public float speed;
    public float maxRotation;
    public float maxMove;
    public float timescale;

    // Use this for initialization
    void Start()
    {
        speed = 2f;
        maxMove = 0f;
        maxRotation = 0f;
        timescale = 0f;

    }

    void Update()
    {
        timescale += Time.deltaTime *0.005f;
        //speed += timescale;
        maxRotation += timescale;
        maxMove += timescale;
        transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin(Time.time * speed));
        //transform.position = new Vector3(maxRotation * Mathf.Sin(Time.time * speed), 0f, 0f);

    }
}