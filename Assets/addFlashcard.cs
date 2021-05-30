using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class addFlashcard : MonoBehaviour
{
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    public GameObject keyObject;
    public GameObject valueObject;
    bool state = false; // false: key side
    string key = "";
    string value = "";
    public Text cardText;
    int index = -1;

    void addCard()
    {
        key = keyObject.GetComponent<Text>().text;
        value = valueObject.GetComponent<Text>().text;
        dictionary.Add(key, value);

        if (dictionary.Count == 1) {
            newCard();
        }
    }

    void flipCard()
    {
        if (state) {
            cardText.text = key;
        } else {
            cardText.text = value;
        }
        state = !state;
    }

    void newCard()
    {
        if (dictionary.Count != 0) {
            // select card from list
            index ++;
            if (index == dictionary.Count) index = 0;
            key = dictionary.ElementAt(index).Key;
            cardText.text = key;

            // set state and values
            state = false;
            value = dictionary[key];
        }
    }

    void backCard()
    {
        if (dictionary.Count != 0) {
            index --;
            if (index < 0) index = dictionary.Count -1;
            key = dictionary.ElementAt(index).Key;
            cardText.text = key;

            state = false;
            value = dictionary[key];
        }
    }
}
