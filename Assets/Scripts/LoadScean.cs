using UnityEngine;
using UnityEngine.UI;

public class LoadScean : MonoBehaviour {

    public bool animationEnd;
    public float SplashTime = 5.0f;
    public Image SplashPanel;
    public Image SplashLogo;
    public GameObject ArControllerGameObject;

    void Start()
    {
        //hope this will help to eliminate square camera on start...
        ARToolkitHelper.OpenCamera();
        ARToolkitHelper.StartCapture();
        ArControllerGameObject.GetComponent<ARController>().StartAR(); //replace from here
    }

    void Update () {

        if (animationEnd)
        {
            if (!SplashPanel.IsDestroyed())
            {
                Invoke("FinishAnimatedLogo", SplashTime);
            }
            //StartCoroutine("FinishAnimatedLogo");
            //SceneManager.LoadSceneAsync("AugmentedReality");
        }
	}

    /*IEnumerator*/void FinishAnimatedLogo()
    {
        //yield return null;
        //ArControllerGameObject.GetComponent<ARController>().StartAR();
        Destroy(SplashPanel);
        Destroy(SplashLogo);
    }
}
