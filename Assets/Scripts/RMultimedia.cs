using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class RMultimedia : MonoBehaviour
{
    private VideoPlayer VideoR;
    public GameObject PlaneVideo;
    public GameObject BRepVideo;
    private Image BRVSprite;
    public Sprite Sreproducir;
    public Sprite Spausar;
    private int confVideo;
    public GameObject Ob_Act_Desact;
    private int confPanel;


    void Start()
    {
        PlaneVideo.SetActive(false);
        VideoR = PlaneVideo.GetComponent<VideoPlayer>();
        confVideo = 0;
        BRVSprite = BRepVideo.GetComponent<Image>();
        BRVSprite.sprite = Sreproducir;
        Ob_Act_Desact.SetActive(false);
    }

    public void RepVideo()
    {
        if (confVideo == 0)
        {
            PlaneVideo.SetActive(true);
            VideoR.Play();
            confVideo = 1;
            BRVSprite.sprite = Spausar;
            VideoR.loopPointReached += CheckOver;
            Ob_Act_Desact.SetActive(false);
        }
        else
        {
            VideoR.Pause();
            PlaneVideo.SetActive(true);
            confVideo = 0;
            BRVSprite.sprite = Sreproducir;
            VideoR.loopPointReached += CheckOver;
        }
    }

    public void StopVideo()
    {
        VideoR.Stop();
        PlaneVideo.SetActive(false);
        confVideo = 0;
        BRVSprite.sprite = Sreproducir;
        VideoR.loopPointReached += CheckOver;
    }

    void CheckOver(VideoPlayer vp)
    {
        //Cambiar boton
    }

    public void Bdatos()
    {
        if (confPanel == 0)
        {
            Ob_Act_Desact.SetActive(true);
            confPanel = 1;
            StopVideo();
        }
        else
        {
            Ob_Act_Desact.SetActive(false);
            confPanel = 0;
        }
    }
}