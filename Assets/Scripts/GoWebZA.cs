using UnityEngine;
using System.Collections;

public class GoWebZA : MonoBehaviour
{
    public string URL = "http://zrobym.by/";

    public void GoWeb()
    {
        Application.OpenURL(URL);
    }
}
