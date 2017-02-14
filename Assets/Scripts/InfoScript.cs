using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    public Image InfoImage;
    public Button InfoButton;
    public Sprite InfoSprite;
    public Sprite InfoCloseSprite;
    public Button AddButton;
    public Button RemButton;
    public Button LnkButton;
    public Toggle ZoomButton;

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
	        AddButton.interactable = false;
            RemButton.interactable = false;
            LnkButton.interactable = false;
            ZoomButton.interactable = false;
        }
        else
	    {
	        InfoImage.gameObject.SetActive(false);
            InfoButton.image.sprite = InfoSprite;
            AddButton.interactable = true;
            RemButton.interactable = true;
            LnkButton.interactable = true;
            ZoomButton.interactable = true;
        }
    }
}
