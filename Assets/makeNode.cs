using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeNode : MonoBehaviour
{
    public GameObject parentNodes;
    public GameObject InputText;
    public GameObject item;
    string input = "";

    void InstantNode()
    {
        input = InputText.GetComponent<Text>().text;

        float ycoord = Convert.ToSingle(0);
        float xcoord = Convert.ToSingle(22.96);
        Vector2 position = new Vector2(xcoord, ycoord);
            
        GameObject tempTextBox = Instantiate(item, position, transform.rotation);
            
        // set parent
        tempTextBox.transform.SetParent(parentNodes.transform, false);
            
        // set text
        Text ButtonText = tempTextBox.GetComponentInChildren<Text>();
        ButtonText.text = input;
    }

    void clearNodes()
    {
        foreach (Transform child in parentNodes.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }
}
