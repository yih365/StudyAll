using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour
{
    public bool isString;
    public Vector3 pos;

    void Start()
    {
        isString = false;
        pos = new Vector3(0, 0, 0);
    }

}
