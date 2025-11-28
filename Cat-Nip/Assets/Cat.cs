using UnityEngine;
using UnityEngine.InputSystem;
public class Cat : MonoBehaviour
{
    public Key leftKey; 
    public Key rightKey; 
    public Key upKey; 
    public Key downKey; 

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[leftKey].isPressed)
        {
            rb.AddForce(Vector2.left);
        }
         if (Keyboard.current[rightKey].isPressed)
        {
            rb.AddForce(Vector2.right);
        }
         if (Keyboard.current[upKey].isPressed)
        {
            rb.AddForce(Vector2.up);
        }
         if (Keyboard.current[downKey].isPressed)
        {
            rb.AddForce(Vector2.down);
        }
    }
}