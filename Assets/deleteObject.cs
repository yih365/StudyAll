using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteObject : MonoBehaviour
{
    public GameObject enterButton;

    void deleteThis()
    {
        GameObject enterButton = GameObject.FindWithTag("EditorOnly");
        addTask addT = enterButton.GetComponent<addTask>();
        GameObject theParent = gameObject.transform.parent.gameObject;
        GameObject thechild = theParent.transform.GetChild(0).gameObject;
        string matchText = thechild.GetComponent<Text>().text;

        if (addT.tasksListAM.Contains(matchText)) {
            addT.tasksListAM.Remove(matchText);
        } else {
            addT.tasksListPM.Remove(matchText);
        }
        addT.sortTasks();
    }
}
