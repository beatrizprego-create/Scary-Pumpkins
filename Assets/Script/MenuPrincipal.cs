using UnityEngine;
using UnityEngine.SceneManagement; // Linha obrigatória para trocar de cena

public class MenuPrincipal : MonoBehaviour
{
    // Função para o botão Começar
    public void ComecarJogo()
    {
        Debug.Log("Carregando o jogo...");
        // Certifique-se de colocar o nome EXATO da sua cena da bolinha entre as aspas
        SceneManager.LoadScene("SampleScene");
    }

    // Função para o botão Sair
    public void SairDoJogo()
    {
        Debug.Log("O jogo fechou!");
        Application.Quit(); // Fecha o jogo (apenas quando o jogo estiver compilado)
        SceneManager.LoadScene("New Scene 2");
    }
}
