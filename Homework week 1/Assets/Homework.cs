using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Homework : MonoBehaviour
{
    public string inputformUser;
    public GameObject input;
    public GameObject output;

    public void textmacted ()
    {
        inputformUser = input.GetComponent<Text>().text;
        if (inputformUser == "Valorant")
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] is found";
		}
        else if (inputformUser == "Point Blank")
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] is found";
		}
        else if (inputformUser == "Dead by daylight")
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] is found";
		}
        else if (inputformUser == "GTA")
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] is found";
		}
        else if (inputformUser == "WWZ")
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] is found";
		}
        else
        {
            output.GetComponent<Text>().text = "[" + inputformUser + "] not found";
		}
	}
}
