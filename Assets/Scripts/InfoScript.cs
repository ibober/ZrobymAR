using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public Image InfoImage;
    public Button InfoButton;
    public Sprite InfoSprite;
    public Sprite InfoCloseSprite;

    void Start()
    {
        InfoButton.image.sprite = InfoSprite;
    }

	public void ShowInfoScreen ()
	{
	    if (!InfoImage.gameObject.activeSelf)
	    {
	        InfoImage.gameObject.SetActive(true);
            InfoButton.image.sprite = InfoCloseSprite;
        }
        else
	    {
	        InfoImage.gameObject.SetActive(false);
            InfoButton.image.sprite = InfoSprite;
        }
    }
}
