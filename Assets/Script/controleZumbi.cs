using UnityEngine;
using UnityEngine.InputSystem;

public class controleZumbi : MonoBehaviour
{
    public float velocidade = 5.0f;

    void Update()
    {
        Vector3 direcao = Vector3.zero;



        if (Keyboard.current.upArrowKey.isPressed)
        { direcao += Vector3.up; }    // Esquerda
        if (Keyboard.current.downArrowKey.isPressed)
        {
            direcao += Vector3.down;
        }   // Direita


        transform.Translate(direcao.normalized * velocidade * Time.deltaTime);

        
    }
}


