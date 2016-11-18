using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public Image InfoImage;

	public void ShowInfoScreen ()
	{
        //why the hell it doen't work??
        InfoImage.enabled = !InfoImage.enabled;
    }
}
