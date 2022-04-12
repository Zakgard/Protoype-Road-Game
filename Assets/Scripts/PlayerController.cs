using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed=35.0f;
    private float horizontallySpeeeInput;
    private float verticalSpeedInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //making input of horizontal speed
        horizontallySpeeeInput = Input.GetAxisRaw("Horizontal");

        //making input of vertical speed
        verticalSpeedInput = Input.GetAxisRaw("Vertical");

        //Moving Forward of the vehicle
        
        transform.Translate(Vector3.forward * Time.deltaTime *speed*verticalSpeedInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontallySpeeeInput);
    }
}
