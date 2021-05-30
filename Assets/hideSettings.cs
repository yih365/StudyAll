using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideSettings : MonoBehaviour
{
    public GameObject settings;
    bool check = false;

    void toggleSettings()
    {
        if (check) {
            settings.SetActive(false);
            check = false;
        } else {
            settings.SetActive(true);
            check = true;
        }
    }
}
