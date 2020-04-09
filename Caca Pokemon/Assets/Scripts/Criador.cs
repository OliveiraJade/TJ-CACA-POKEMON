using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Criador : MonoBehaviour
{
    public GameObject carreira;

    public Text contador;


    private float tempoRestante = 60f;


    public void ChocaCarreira()
    {
        int quantidade = 3;
        for(int i = 0; i < quantidade; i++)
        {

            Vector3 carreiraPosicao = new Vector3(Random.Range(-7f , 7f) , Random.Range(-4f, 4f) , 0f);
        Instantiate(carreira, carreiraPosicao, Quaternion.identity); 
    }

}

    // Update is called once per frame
    void Update()
    {
        tempoRestante -= Time.deltaTime;
        contador.text = " TEMPO RESTANTE \n" + Mathf.Round(tempoRestante) + "SEGUNDOS";

        if(tempoRestante < -5)
        {
            SceneManager.LoadScene("CenaFim");

        }else if(tempoRestante < 0)
        {
            contador.text = "TEMPO\nESGOTADO";
        }else if(tempoRestante < 10)
        {
            contador.color = Color.red;
        }else if(tempoRestante < 30)
        {
            contador.color = Color.yellow;
        }
    }
}
