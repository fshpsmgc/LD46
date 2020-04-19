using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public string LogText;

    private void Awake() {
        LogText = "";
    }

    public static void Add(string s){
        GameObject.Find("GameController").GetComponent<Log>().LogText += s + '\n';
    }

    public static string GetLog(){
        return GameObject.Find("GameController").GetComponent<Log>().LogText;
    }
}
