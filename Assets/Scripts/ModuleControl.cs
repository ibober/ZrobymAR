using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ModuleControl : MonoBehaviour
{
    public List<GameObject> houseList = new List<GameObject>();
    public Toggle ZoomButton;
    public float ZoomFactor = 1.5f;

    public void ModuleAdd()
    {
        foreach (GameObject activeHouse in houseList)
        {
            if (activeHouse.activeSelf)
            {
                List<GameObject> module = activeHouse.GetComponent<ModuleList>().module;

                for (int i = 1; i < module.Count; i++)
                {
                    if (!module[i].activeSelf)
                    {
                        module[i].SetActive(true);
                        break;
                    }
                }

            }
        }
    }

    public void ModuleRemove()
    {
        foreach (GameObject activeHouse in houseList)
        {
            if (activeHouse.activeSelf)
            {
                List<GameObject> module = activeHouse.GetComponent<ModuleList>().module;

                for (int i = module.Count - 1; i > 0; i--)
                {
                    if (module[i].activeSelf)
                    {
                        module[i].SetActive(false);
                        break;
                    }
                }
            }
        }
    }

    public void ModuleMagnify()
    {
        foreach (GameObject activeHouse in houseList)
        {
            if (activeHouse.activeSelf)
            {
                if (ZoomButton.isOn)
                {
                    activeHouse.transform.localScale *= ZoomFactor;
                }
                else
                {
                    activeHouse.transform.localScale /= ZoomFactor;
                }
            }
        }
    }
}