using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject text;

    public void Trigger()
    {
        if (text.activeInHierarchy == false)
        {
            text.SetActive(true);

        }
        else
        {
            text.SetActive(false);
        }
    }
}