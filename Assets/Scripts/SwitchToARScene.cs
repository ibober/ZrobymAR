using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchToARScene : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    new WaitForSeconds(5);
	    SceneManager.LoadScene("AugmentedReality");
	}
}
