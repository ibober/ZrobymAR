using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public Image InfoImage;
    //private bool isActive;

    //void Start()
    //{
    //    isActive = InfoImage.gameObject.activeSelf;
    //}

	public void ShowInfoScreen ()
	{
	    if (!InfoImage.gameObject.activeSelf)
	    {
	        InfoImage.gameObject.SetActive(true);
	    }
	    else
	    {
	        InfoImage.gameObject.SetActive(false);
        }
        //isActive = !isActive;
	    //InfoImage.gameObject.SetActive(isActive);
	}
}
