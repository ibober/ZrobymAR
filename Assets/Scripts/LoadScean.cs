using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScean : MonoBehaviour {

    public bool animationEnd;
	
	// Update is called once per frame
	void Update () {
	
        if (animationEnd)
        {
            SceneManager.LoadScene("AugmentedReality");
        }
	}
}
