using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Website : MonoBehaviour
{
    public string URL = "https://museomosqueraar.wixsite.com/museomosqueraar";

    public void BWebSite()
    {
        Application.OpenURL(URL);
    }

}
