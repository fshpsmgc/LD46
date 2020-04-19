using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreationController : MonoBehaviour
{
    public ProjectController project;
    public GameController gameController;

    public InputField gameNameInput;
    public InputField themeInput;
    public Dropdown genreDropdown;
    public Developer mainDev;

    public InputField projectName;
    public InputField projectTheme;
    
    public int pointsLeft;
    public int GDPoints;
    public int ProgrammingPoints;
    public int ArtPoints;
    public int SoundPoints;
    public int Money;

    public InputField GDLabel;
    public InputField ProgrammingLabel;
    public InputField ArtLabel;
    public InputField SoundLabel;
    public InputField MoneyLabel;
    public Text SkillsLabel;

    public InputField devNameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkillsLabel.text = "Skills: " + pointsLeft.ToString();
    }

    public void StartDevelopment(){
        project.gameName = gameNameInput.text;
        project.theme = themeInput.text;
        project.genre = genreDropdown.options[genreDropdown.value].text;
        
        projectName.text = gameNameInput.text;
        projectTheme.text = themeInput.text;

        mainDev.stats.GameDesignSkill = GDPoints;
        mainDev.stats.ProgrammingSkill = ProgrammingPoints;
        mainDev.stats.ArtSkill = ArtPoints;
        mainDev.stats.SoundSkill = SoundPoints;
        mainDev.DevName = devNameInput.text;
        
        gameController.Money = Money;
        gameController.StartGame();
        Log.Add($"Development on {project.gameName} ({project.theme},{project.genre}) was started by {mainDev.DevName}");
    }

    public void AddGDPoints(){
        if(pointsLeft <= 0) return;
        GDPoints++;
        pointsLeft--;
        GDLabel.text = GDPoints.ToString(); 
    }

    public void AddProgrammingPoints(){
        if(pointsLeft <= 0) return;
        ProgrammingPoints++;
        pointsLeft--;
        ProgrammingLabel.text = ProgrammingPoints.ToString(); 
    }

    public void AddArtPoints(){
        if(pointsLeft <= 0) return;
        ArtPoints++;
        pointsLeft--;
        ArtLabel.text = ArtPoints.ToString(); 
    }

    public void AddSoundPoints(){
        if(pointsLeft <= 0) return;
        SoundPoints++;
        pointsLeft--;
        SoundLabel.text = SoundPoints.ToString(); 
    }

    public void AddMoney(){
        if(pointsLeft <= 0) return;
        Money += 10;
        pointsLeft--;
        MoneyLabel.text = Money.ToString(); 
    }
}
