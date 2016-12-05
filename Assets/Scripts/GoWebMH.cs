using UnityEngine;
using System.Collections;

public class GoWebMH : MonoBehaviour
{
    public string URL = "http://modular-house.by/";

    public void GoWeb()
    {
        Application.OpenURL(URL);
    }
}
