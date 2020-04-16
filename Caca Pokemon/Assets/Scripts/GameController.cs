using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text pontuacao;

    public InputField nome;

    // Start is called before the first frame update

    public void Salvar()
    {
        PlayerPrefs.SetString("NomeJogador", nome.text);
        pontuacao.text = PlayerPrefs.GetString("NomeJogador") + " : " + PlayerPrefs.GetInt("PontosAtual");
        nome.text = "";

        SceneManager.LoadScene("CenaRanking");
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
