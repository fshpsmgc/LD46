using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectController : MonoBehaviour
{
    public string gameName;
    public string genre;
    public string theme;

    public DevStats nameChangeEffect;
    public int nameChangeBoredom;
    public DevStats genreChangeEffect;
    public int genreChangeBoredom;
    public DevStats themeChangeEffect;
    public int themeChangeBoredom;

    public InputField NameInput;
    public Dropdown GenreInput;
    public InputField ThemeInput;

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
        controller.BoredomPoints -= nameChangeBoredom;
        gameName = NameInput.text;
    }

    public void ChangeGenre(){  
        controller.ApplyPoints(genreChangeEffect);
        controller.BoredomPoints -= genreChangeBoredom;
        genre = GenreInput.itemText.text;
    }

    public void ChangeTheme(){
        controller.ApplyPoints(themeChangeEffect);
        controller.BoredomPoints -= themeChangeBoredom;
        theme = ThemeInput.text;
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
