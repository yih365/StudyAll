using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addTask : MonoBehaviour
{
    public GameObject task;
    public GameObject hour;
    public GameObject minutes;
    public GameObject zone;
    public GameObject parentTexts;
    public GameObject prefabText;
    public List<string> tasksListAM = new List<string>();
    public List<string> tasksListPM = new List<string>();

    void clearAll()
    {
        tasksListAM.Clear();
        tasksListPM.Clear();
        foreach (Transform child in parentTexts.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }

    void add()
    {
        string hourtext = hour.GetComponent<Text>().text;
        string mintext = minutes.GetComponent<Text>().text;
        string zonetext = zone.GetComponent<Text>().text;
        string tasktext = task.GetComponent<Text>().text;

        string totalText = hourtext + ":" + mintext + " " + zonetext + "    " + tasktext;

        if (zonetext == "AM") {
            tasksListAM.Add(totalText);
            tasksListAM.Sort();
        } else { //PM
            tasksListPM.Add(totalText);
            tasksListPM.Sort();
        }
        sortTasks();
    }

    public void sortTasks()
    {
        // delete all children
        foreach (Transform child in parentTexts.transform) {
            GameObject.Destroy(child.gameObject);
        }
        
        // add new children from sorted list
        for (var i = 0; i < tasksListAM.Count; i ++) {
            string childText = tasksListAM[i];
            float num = Convert.ToSingle(-6.11-45.35*i);
            float xcoord = Convert.ToSingle(0);
            Vector2 position = new Vector2(xcoord, num);
            
            GameObject tempTextBox = Instantiate(prefabText, position, transform.rotation);
            
            // set parent
            tempTextBox.transform.SetParent(parentTexts.transform, false);
            
            // set text
            tempTextBox.GetComponentInChildren<Text>().text = childText;
        }
        for (var i = 0; i < tasksListPM.Count; i ++) {
            string childText = tasksListPM[i];
            float num = Convert.ToSingle(-6.11-45.35*(i+tasksListAM.Count));
            float xcoord = Convert.ToSingle(0);
            Vector2 position = new Vector2(xcoord, num);
            
            GameObject tempTextBox = Instantiate(prefabText, position, transform.rotation);
            
            // set parent
            tempTextBox.transform.SetParent(parentTexts.transform, false);
            
            // set text
            tempTextBox.GetComponentInChildren<Text>().text = childText;
        }
    }
}
