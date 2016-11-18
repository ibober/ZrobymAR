using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashShowCompanyAndGoAR : MonoBehaviour
{
    public float TimeBeforeName = 3.0f;
    public float TimeBeforeAugmentation = 1.5f;
    public Text CompanyName;

    void Start ()
    {
        CompanyName.text = "";
        Invoke("ShowCompanyName", TimeBeforeName);
    }

    void ShowCompanyName()
    {
        CompanyName.text = "by\nZROBYM Architects";
        Invoke("SwitchToARScene", TimeBeforeAugmentation);
    }

    void SwitchToARScene()
    {
        //dont know why Unity crashes with it
	    //SceneManager.LoadScene("AugmentedReality");
    }
}
