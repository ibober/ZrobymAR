using UnityEngine;
using System.Collections;
using System.Threading;

public class ModuleAnimation : MonoBehaviour {

    public Transform[] component;
    int countComponent = 0;
    bool next = true;

    void Start()
    {
        countComponent = transform.childCount;
        component = new Transform[countComponent];

        for (int i = 0; i < countComponent; i++)
        {
            component[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update() {


        if (gameObject.activeSelf)
        {
            for (int i = 0; i < countComponent; i++)
            {
                component[i].gameObject.SetActive(false);
            }
                StartCoroutine(spawnElement());
               
            }

        }

    IEnumerator spawnElement()
    {
        for (int i = 0; i < countComponent; i++)
        {
            if (!component[i].gameObject.activeSelf)
            {
                yield return new WaitForSeconds(0.02f);
                component[i].gameObject.SetActive(true);


            }
        }
    }
    }



        
	
	

