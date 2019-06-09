using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;




	// Use this for initialization
	void Start () {

        _cameraOffset = transform.position - player.position;



    }


    void LateUpdate()
    {
        Vector3 newPos = player.position + _cameraOffset;

        
    }



    // Update is called once per frame
    //void Update () {
    //       Vector3 lookOnObject = player.position - transform.position;
    //       lookOnObject = player.position - transform.position;
    //       transform.forward = lookOnObject.normalized;



    //}
}
