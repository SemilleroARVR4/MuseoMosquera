using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecorridoAR : MonoBehaviour
{
    public GameObject C_MenuGeneral;
    public GameObject C_RecorridoAR;
    public GameObject C_Trivia;

    public GameObject Inicial;
    public GameObject FondoInicial;
    public GameObject IMG_T;
    public GameObject CTutorial;

    public GameObject ButtonLinterna;
    public GameObject ButtonTutorial;
    public GameObject ButtonSalirAR;

    public GameObject TP1;
    public GameObject TP2;
    public GameObject TP3;

    private int resetSeccion;
    private int CtrlTuto;
    
    // Start is called before the first frame update
    void Start()
    {
        C_MenuGeneral.SetActive(false);
        C_RecorridoAR.SetActive(true);
        C_Trivia.SetActive(false);

        Inicial.SetActive(true);
        FondoInicial.SetActive(true);
        IMG_T.SetActive(false);
        CTutorial.SetActive(false);

        ButtonLinterna.SetActive(false);
        ButtonTutorial.SetActive(false);

        resetSeccion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetSeccion == 0)
        {
            Start();
        }
    }

    public void BEmpezar() 
    {
        Inicial.SetActive(false);
        FondoInicial.SetActive(false);
        IMG_T.SetActive(true);
        CTutorial.SetActive(false);

        ButtonLinterna.SetActive(true);
        ButtonTutorial.SetActive(true);

        resetSeccion = 1;
        CtrlTuto = 0;
    }

    public void BSalirRecorrido()
    {
        C_MenuGeneral.SetActive(true);
        C_RecorridoAR.SetActive(false);
        C_Trivia.SetActive(false);

        resetSeccion = 0;
    }

    public void BTutorial() 
    {
        CTutorial.SetActive(true);
        ButtonTutorial.SetActive(false);
        Tutorial();

        resetSeccion = 1;
    }

    public void Tutorial() 
    {
        if (CtrlTuto == 0)
        {
            ButtonLinterna.SetActive(false);
            ButtonSalirAR.SetActive(false);
            TP1.SetActive(true);
            TP2.SetActive(false);
            TP3.SetActive(false);
            ButtonLinterna.SetActive(true);
            ButtonSalirAR.SetActive(true);
            CtrlTuto = 1;
        }
        else {
            if (CtrlTuto == 1) {
                TP1.SetActive(false);
                TP2.SetActive(true);
                TP3.SetActive(false);
                CtrlTuto = 2;
            }
            else 
            {
                if (CtrlTuto == 2)
                {
                    TP1.SetActive(false);
                    TP2.SetActive(false);
                    TP3.SetActive(true);
                    CtrlTuto = 3;
                }
                else
                {
                    BEmpezar();
                }
            }
        }
    }
}
