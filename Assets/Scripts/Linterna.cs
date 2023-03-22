using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Linterna : MonoBehaviour
{
    public bool lint = false;
    // Start is called before the first frame update
    void Start()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFlash(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BLinterna()
    {
        lint = !lint;
        VuforiaBehaviour.Instance.CameraDevice.SetFlash(lint);
    }
}