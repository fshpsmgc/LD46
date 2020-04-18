using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectController : MonoBehaviour
{
    public string gameName;
    public string genre;
    public string theme;

    public DevStats nameChangeEffect;
    public DevStats genreChangeEffect;
    public DevStats themeChangeEffect;

    GameController controller;

    void Awake(){
        controller = GetComponent<GameController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName(){
        controller.ApplyPoints(nameChangeEffect);
    }

    public void ChangeGenre(){  
        controller.ApplyPoints(genreChangeEffect);
    }

    public void ChangeTheme(){
        controller.ApplyPoints(themeChangeEffect);
    }

    public string GetDevsList(){
        string result = "Hired Devs:\n";
        GameObject[] devs = GameObject.FindGameObjectsWithTag("Developer");
        foreach(var dev in devs){
            result += dev.GetComponent<Developer>().DevName + "\n";
        }

        result += "Potential hires:\n";
        GameObject[] newdevs = GameObject.FindGameObjectsWithTag("DeveloperTemp");
        foreach(var dev in newdevs){
            result += dev.GetComponent<Developer>().DevName + "\n";
        }
        return result;
    }
}
