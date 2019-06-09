using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour {

    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 300;
    public float moveSpeed = 2;
    public Vector3 Value;

#region move


    // Use this for initialization
    void Start () {

         Value = this.gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        ListenClick();
        ApplyInput(moveAxis,turnAxis);
	
	}

    private void ApplyInput(float moveInput,float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }




    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed );   
    }

    private void Turn(float input)
    {
        //物体平移
        transform.Translate(0,input * rotationRate * Time.deltaTime,0);

    }

    private void ListenClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //判断是否点击事件
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log("111");

                DOTween.To(() => Value, x => Value = x, new Vector3(1, 3, 3),2);


            }
                 
        }
    }


    #endregion
}
