using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScean : MonoBehaviour {

    public bool animationEnd;
	
	void Update () {

        if (animationEnd)
        {
            StartCoroutine("LoadScene");
            //SceneManager.LoadSceneAsync("AugmentedReality");
        }
	}

    IEnumerator LoadScene()
    {
        yield return null;
        SceneManager.LoadSceneAsync("AugmentedReality");

    }
}
