using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float mainSpeed;
    [SerializeField]
    private float sensitive; 
    private Vector3 lastMousePosition; 
    private void Awake() 
    {
        lastMousePosition = new Vector3(Screen.width/2, Screen.height/2, 0);
    }
    private void FixedUpdate()
    {
        if(Input.GetButton("Fire2"))
            RotateTransform();

        Vector3 direction = GetMovementDirection();
        direction = direction * mainSpeed * Time.deltaTime;

        transform.Translate(direction);
    }
    private void RotateTransform()
    {
        lastMousePosition = Input.mousePosition - lastMousePosition;
        lastMousePosition = new Vector3(-lastMousePosition.y * sensitive, 
                                        lastMousePosition.x * sensitive, 0);
        lastMousePosition = new Vector3(transform.eulerAngles.x + lastMousePosition.x, 
                                        transform.eulerAngles.y + lastMousePosition.y, 0);

        transform.eulerAngles = lastMousePosition;
        lastMousePosition =  Input.mousePosition;
    }
    private Vector3 GetMovementDirection() 
    { 
        Vector3 direction = new Vector3();

        if (Input.GetKey (KeyCode.W))
        {
            direction += new Vector3(0, 0 , 1);
        }
        if (Input.GetKey (KeyCode.S))
        {
            direction += new Vector3(0, 0, -1);
        }
        if (Input.GetKey (KeyCode.A))
        {
            direction += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey (KeyCode.D)){
            direction += new Vector3(1, 0, 0);
        }
        return direction;
    }
}
