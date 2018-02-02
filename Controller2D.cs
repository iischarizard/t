using UnityEngine;
using System.Collections;

public class Controller2D : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    
    void start(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void move(float xVel, float yVel){
        Vector2 velocity = new Vector2(xVel, yVel);
        rb.MovePosition(rb.position + velocity * speed * Time.fixedDeltaTime);
    }

}
