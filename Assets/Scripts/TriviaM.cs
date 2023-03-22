using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TriviaM : MonoBehaviour
{
    public GameObject C_MenuGeneral;
    public GameObject C_RecorridoAR;
    public GameObject C_Trivia;

    public GameObject[] C_PTrivia;
    public GameObject[] C_RTrivia;

    public GameObject InicialTrivia;
    public GameObject FondoInicial;

    public GameObject Reanudar;

    public int score = 0;
    public Text Txtscore;
    public int pregunta=0;
    private int respondio = 0;

    public AudioSource SonidoFondo;
    public AudioClip Music;


    // Start is called before the first frame update
    public void Start()
    {
        C_MenuGeneral.SetActive(false);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(true);

        if (pregunta > 0 || respondio ==1)
        {
            Reanudar.SetActive(true);
        }
        else {
            Reanudar.SetActive(false);
        }
        for (int i = 0; i < C_PTrivia.Length; i++)         // Falso para todas los C preguntas desactivar
        {
            C_PTrivia[i].SetActive(false);
            C_RTrivia[i].SetActive(false);
        }

        FondoInicial.SetActive(true);
        InicialTrivia.SetActive(true);

        SonidoFondo.clip = Music;

        Debug.Log("Start - Pregunta:"+pregunta);
        Debug.Log("Respondio:" + respondio);
    }

    // Update is called once per frame
    void Update()
    {
        if (pregunta > 1) { Reanudar.SetActive(true); }
    }


    public void BEmpezar() 
    {
        InicialTrivia.SetActive(false);
        C_PTrivia[0].SetActive(true);
        score = 0;
        pregunta = 0;
        SonidoFondo.Play();
        Debug.Log("BEmpezar - Pregunta:" + pregunta);
        Debug.Log("Respondio:" + respondio);
    }
    public void BSalirTrivia() 
    {
        C_MenuGeneral.SetActive(true);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(false);
        SonidoFondo.Stop();
        Debug.Log("Salir Trivia - Pregunta:" + pregunta);
        Debug.Log("Respondio:" + respondio);
    }
    public void BRenaudar()
    {
        InicialTrivia.SetActive(false);
        if (respondio == 1)
        {
            pregunta ++;
        }
        C_PTrivia[pregunta].SetActive(true);
        respondio = 0;
        SonidoFondo.Play();
        Debug.Log("Reanudar - Pregunta:" + pregunta);
        Debug.Log("Respondio:" + respondio);
    }

    public void BCorrecta()
    {
        score++;
        C_PTrivia[pregunta].SetActive(false);
        C_RTrivia[pregunta].SetActive(true);
        Debug.Log("Correcta - Pregunta:" + pregunta);
        respondio = 1;
        Debug.Log("Respondio:" + respondio);
    }

    public void BIncorrecta()
    {
        C_PTrivia[pregunta].SetActive(false);
        C_RTrivia[pregunta].SetActive(true);
        Debug.Log("Incorrecta - Pregunta:" + pregunta);
        respondio = 1;
        Debug.Log("Respondio:" + respondio);
    }

    public void BNext()
    {
        pregunta++;
        C_RTrivia[pregunta-1].SetActive(false);
        C_PTrivia[pregunta].SetActive(true);
        Txtscore.text = "Respuestas Correctas: " + score + "/10";
        Debug.Log("Next - Pregunta:" + pregunta);
        respondio = 0;
        Debug.Log("Respondio:" + respondio);
    }
    public void BFinal()
    {
        score = 0;
        pregunta = 0;
        respondio = 0;
        C_PTrivia[pregunta].SetActive(false);
        C_MenuGeneral.SetActive(true);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(false);
        SonidoFondo.Stop();
        Debug.Log("Final - Pregunta:" + pregunta);
        Debug.Log("Respondio:" + respondio);
    }
    /*
    public void BRefresh()
    {
        C_MenuGeneral.SetActive(false);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(true);

        if (pregunta > 1) { Renaudar.SetActive(true); }
        for (int i = 0; i < C_PTrivia.Length; i++)         // Falso para todas los C preguntas desactivar
        {
            C_PTrivia[i].SetActive(false);
            C_RTrivia[i].SetActive(false);
        }

        InicialTrivia.SetActive(true);
        Renaudar.SetActive(false);
        Debug.Log(pregunta);
    }*/
}
