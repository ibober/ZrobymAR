using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ZrobymHouseResize : MonoBehaviour
{
    public void ModuleAdd()
    {
        Debug.Log("! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! BUTTON CLICKED ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !");
        GameObject.Find("Mass2").GetComponent<Renderer>().enabled =
                !GameObject.Find("Mass2").GetComponent<Renderer>().enabled;
    }

    public void ModuleRemove()
    {
        
    }
}
