using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScean : MonoBehaviour {

    public bool animationEnd;
    public float SplashTime = 5.0f;
    public Image SplashPanel;
    public Image SplashLogo;

    void Update () {

        if (animationEnd)
        {
            Invoke("FinishAnimatedLogo", SplashTime);
            //StartCoroutine("FinishAnimatedLogo");
            //SceneManager.LoadSceneAsync("AugmentedReality");
        }
	}

    /*IEnumerator*/void FinishAnimatedLogo()
    {
        //yield return null;
        Destroy(SplashPanel);
        Destroy(SplashLogo);
    }
}
