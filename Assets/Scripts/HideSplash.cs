using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideSplash : MonoBehaviour
{
    public float waitTime = 3.0f;
    private RectTransform panel;

    void Start()
    {
        panel = GetComponent<RectTransform>();
        Invoke("HideSplash", 3.0f);
    }

    void SetSplashInactive()
    {
        //((GameObject)panel).SetActive(false);
    }
}
