using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public Controller2D controller;
    
    private float xVel, yVel;
    
    void Start(){
        xVel = 0;
        yVel = 0;
    }

    void Update() {
        xVel = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        yVel = Input.GetAxisRaw("Vertical") * Time.deltaTime;
    }
    
    void FixedUpdate(){
        controller.move(xVel, yVel);
    }
}
