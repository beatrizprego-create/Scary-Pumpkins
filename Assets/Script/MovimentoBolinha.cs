using UnityEngine;

public class MovimentoBolinha2D : MonoBehaviour
{
    public float velocidade = 10f;

    private Rigidbody2D rb;
    private Vector2 direcao;

    
    private float tempoUltimoRebote;
    private const float COOLDOWN_REBOTE = 0.05f; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        direcao = new Vector2(1f, 0.8f).normalized;

       
        rb.linearVelocity = direcao * velocidade;
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        
        if (Time.time - tempoUltimoRebote < COOLDOWN_REBOTE)
        {
            return;
        }

        
        tempoUltimoRebote = Time.time;

        
        Vector2 normalContato = colisao.contacts[0].normal;

        
        direcao = Vector2.Reflect(direcao, normalContato).normalized;

        
        if (Mathf.Abs(direcao.x) < 0.2f)
        {
            direcao.x += (direcao.x >= 0) ? 0.25f : -0.25f;
        }

        
        if (Mathf.Abs(direcao.y) < 0.2f)
        {
            direcao.y += (direcao.y >= 0) ? 0.25f : -0.25f;
        }

        
        direcao = direcao.normalized;

        
        rb.linearVelocity = direcao * velocidade;
    }
}
