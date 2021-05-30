using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class controlNode : MonoBehaviour
{
    bossScript centerScript;
    private GameObject theobject;
    public GameObject imagePrefab;

    void Start()
    {
        theobject = GameObject.FindWithTag("Player");
        centerScript = theobject.GetComponent<bossScript>();
    }

    void lineFunc()
    {
        if (centerScript.isString) {
            // end line
            var newobject = Instantiate(imagePrefab);
            newobject.transform.SetParent(theobject.transform, false);
            newobject.transform.position = (centerScript.pos + gameObject.transform.position) / 2;
            Vector3 dif = centerScript.pos - gameObject.transform.position;
            //newobject.width = dif.magnitude;
            //newobject.height = 5;
            var theBarRectTransform = newobject.transform as RectTransform;
            theBarRectTransform.sizeDelta = new Vector2 (dif.magnitude, 5);

            newobject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180 * Mathf.Atan(dif.y / dif.x) / Mathf.PI));

            centerScript.isString = false;
        } else {
            // set line
            centerScript.pos = gameObject.transform.position;
            centerScript.isString = true;
        }
    }

    void mouseDrag()
    {
        Vector3 pos_move = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        transform.position = new Vector3( pos_move.x, pos_move.y, 0 );
    }
}
