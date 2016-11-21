using UnityEngine;
using UnityEngine.UI;

public class TemporaryLogo : MonoBehaviour
{
    public Image TempLogo;
    public Image MH;

	void Start ()
	{
	    Invoke("Hide",1f);
	}
	
	void Hide ()
	{
	    TempLogo.enabled = false;
	    MH.enabled = false;
	}
}
