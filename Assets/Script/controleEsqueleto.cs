using UnityEngine;
using UnityEngine.InputSystem;

public class controleRaquete : MonoBehaviour
{
    public float velocidade = 5.0f;
    public CharacterController rb; 
    private Vector2 movimento;

    void Start()
    {
        
        rb = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        movimento = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
        {
            movimento += Vector2.up;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            movimento += Vector2.down;
        }

        movimento = movimento.normalized;
    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movimento * velocidade * Time.fixedDeltaTime);
    }
}