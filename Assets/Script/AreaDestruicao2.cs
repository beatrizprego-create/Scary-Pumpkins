
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaDestruicao2 : MonoBehaviour
{
    public TextMeshProUGUI pontos;
    public int pontosInteiros = 0;

    public GameObject meuPrefab;
    public GameObject referencia;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bolinha"))
        {
            pontosInteiros++;

            pontos.text = "Zumbi P: " + pontosInteiros.ToString();

            Destroy(other.gameObject);

            if (pontosInteiros >= 10)
            {
                SceneManager.LoadScene("New Scene 3");
                return;
            }

            Instantiate(
                meuPrefab,
                referencia.transform.position,
                Quaternion.identity
            );
        }
    }
}

