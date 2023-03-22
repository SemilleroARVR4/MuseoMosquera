using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesMenuGeneral : MonoBehaviour
{
    public string URL = "https://youtube.com/playlist?list=PLXFKdhYDX06_LElipAGvdboDPNk3q4-Ij";
    public GameObject C_MenuGeneral;
    public GameObject C_RecorridoAR;
    public GameObject C_Trivia;
    public GameObject Ob_Act_Desact;
    public TriviaM triviaM;
    private int confPanel;


    // Start is called before the first frame update
    void Start()
    {
        C_MenuGeneral.SetActive(true);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(false);
        Ob_Act_Desact.SetActive(false);
        confPanel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BrecorridoAR()
    {
        C_MenuGeneral.SetActive(false);
        C_RecorridoAR.SetActive(true);
        C_Trivia.SetActive(false);
    }

    public void BVerMiniserie()
    {
        Application.OpenURL(URL);
    }

    public void BTrivia()
    {
        C_MenuGeneral.SetActive(false);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(true);
        triviaM.Start();
    }

    public void Binfo() 
    {
        if (confPanel == 0)
        {
            Ob_Act_Desact.SetActive(true);
            confPanel = 1;
        }
        else {
            Ob_Act_Desact.SetActive(false);
            confPanel = 0;
        }
    }

    public void BSalirApp() 
    {
        Application.Quit();
    }
}
