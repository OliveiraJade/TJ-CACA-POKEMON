using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaRanking : MonoBehaviour
{
    public Text listaCampeões;

    // O início é chamado antes da primeira atualização de quadro
    void Start()
    {
        MontaListaCampeoes();
    }

    void MontaListaCampeoes()
    {
        string suaPontuacao = " ";

        if (PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador1"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosJogador1"));
            PlayerPrefs.SetInt("PontosJogador1", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador2"));
            PlayerPrefs.SetString("NomeJogador2", PlayerPrefs.GetString("NomeJogador1"));
            PlayerPrefs.SetString("NomeJogador1", PlayerPrefs.GetString("NomeJogador"));

        }
        else if (PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador2"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador2"));
            PlayerPrefs.SetString("NomeJogador2", PlayerPrefs.GetString("NomeJogador"));
        }
        else if (PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador3"))
        {

            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosAtual"));
            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador"));

        }
        else
        {
            suaPontuacao = "\nSua Pontuação: " + PlayerPrefs.GetInt("PontosAtual");
        }

        listaCampeões.text = "1º - " + PlayerPrefs.GetString("NomeJogador1");
        listaCampeões.text += " - " + PlayerPrefs.GetInt("PontosJogador1");

        listaCampeões.text += "\n2º - " + PlayerPrefs.GetString("NomeJogador2");
        listaCampeões.text += " - " + PlayerPrefs.GetInt("PontosJogador2");

        listaCampeões.text += "\n3º - " + PlayerPrefs.GetString("NomeJogador3");
        listaCampeões.text += " - " + PlayerPrefs.GetInt("PontosJogador3");

        listaCampeões.text += suaPontuacao;

        PlayerPrefs.SetString("NomeJogador","");
        PlayerPrefs.SetInt("PontosAtual",0);
    }

    public void LimparRanking()
    {

        PlayerPrefs.SetString("NomeJogador1", " ");
        PlayerPrefs.SetInt("PontosJogador1", 0);

        PlayerPrefs.SetString("NomeJogador2", " ");
        PlayerPrefs.SetInt("PontosJogador2", 0);

        PlayerPrefs.SetString("NomeJogador3", " ");
        PlayerPrefs.SetInt("PontosJogador3", 0);
        listaCampeões.text = " ";
    }
    // Atualização é chamada uma vez por quadro
    void Update()

    {

    }
}
