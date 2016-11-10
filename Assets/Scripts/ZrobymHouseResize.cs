using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ZrobymHouseResize : MonoBehaviour
{
    private bool isActive = true;

    public void ModuleAdd()
    {
        Debug.Log("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! BUTTON CLICKED ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
        GameObject.Find("Mass1").GetComponent<Renderer>().enabled =
                !GameObject.Find("Mass1").GetComponent<Renderer>().enabled;


        //GameObject modularHouse = new GameObject();
        //if (GameObject.Find("longhouseAR") != null)
        //{
        //Debug.Log("Inside If");
        //ARMarker[] markers = FindObjectsOfType(typeof(ARMarker)) as ARMarker[];
        //foreach...
        //if (myMarker.Visible) Debug.Log("Marker is visible.");

        //GameObject.Find("longhouseAR").GetComponent<Renderer>().enabled =
        //    !GameObject.Find("longhouseAR").GetComponent<Renderer>().enabled;

        //if (GameObject.Find("longhouseAR").activeInHierarchy)
        //{
        //    GameObject.Find("longhouseAR").GetComponent()
        //    Debug.Log("HIDING");
        //}
        //else
        //{
        //    GameObject.Find("longhouseAR").SetActive(true); //.enabled = false;
        //    Debug.Log("SHOWING");
        //}
        //}
    }

    public void ModuleRemove()
    {
        
    }
}
