using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public float GameDesignPoints;
    public float MaxGameDesignPoints;
    public float ProgrammingPoints;
    public float MaxProgrammingPoints;
    public float ArtPoints;
    public float MaxArtPoints;
    public float SoundPoints;
    public float MaxSoundPoints;
    public float BoredomPoints;
    public float MaxBoredomPoints;
    public float BoredomModifier;

    public float Money;

    [Header("UI")]
    [SerializeField] Slider GameDesignSlider;
    [SerializeField] Slider ProgrammingSlider;
    [SerializeField] Slider ArtSlider;
    [SerializeField] Slider SoundSlider;
    [SerializeField] Slider BoredomSlider;
    bool gameStarted;

    public GameObject GameCanvas;
    public GameObject EndCanvas;
    public Text GameLog;
    
    private void Awake() {
        Screen.SetResolution(1280,720, FullScreenMode.Windowed, 60);
    }
    
    // Start is called before the first frame update
    public void StartGame()
    {
        GameDesignSlider.maxValue = MaxGameDesignPoints;
        ProgrammingSlider.maxValue = MaxProgrammingPoints;
        ArtSlider.maxValue = MaxArtPoints;
        SoundSlider.maxValue = MaxSoundPoints;
        BoredomSlider.maxValue = MaxBoredomPoints;
        gameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted){
            BoredomPoints += Time.deltaTime * (Developer.Count + 1) * BoredomModifier;
            if(BoredomPoints >= MaxBoredomPoints){
                BoredomPoints = 0;
                DeleteDeveloper();
            }
    
            BoredomSlider.value = BoredomPoints;

            if(GameDesignPoints >= MaxGameDesignPoints && 
                ProgrammingPoints >= MaxProgrammingPoints &&
                ArtPoints >= MaxArtPoints &&
                SoundPoints >= MaxSoundPoints) GameOver(true);
        }
    }

    public void ApplyPoints(DevStats stats) {
        if(!gameStarted) return;
        if(GameDesignPoints < MaxGameDesignPoints) GameDesignPoints += stats.GameDesignSkill;
        if(ProgrammingPoints < MaxProgrammingPoints) ProgrammingPoints += stats.ProgrammingSkill;
        if(ArtPoints < MaxArtPoints) ArtPoints += stats.ArtSkill;
        if(SoundPoints < MaxSoundPoints) SoundPoints += stats.SoundSkill;
        UpdateUI();
    }

    public void UpdateUI() {
        GameDesignSlider.value = GameDesignPoints;
        ProgrammingSlider.value = ProgrammingPoints;
        ArtSlider.value = ArtPoints;
        SoundSlider.value = SoundPoints;
    }

    public void DeleteDeveloper(){
        GameObject[] devs = GameObject.FindGameObjectsWithTag("Developer");
        if(devs.Length == 0){
            GameOver();
            return;
        }
        Destroy(devs[Random.Range(0, devs.Length - 1)]);
    }

    public void GameOver(bool victory = false){
        gameStarted = false;
        GameCanvas.SetActive(false);
        EndCanvas.SetActive(true);
        if(victory){
            Log.Add($"Game was successfully finished and, like, {Random.Range(30, 250)} people played it. Great job!");
        }else{
            float gdPercentage = GameDesignPoints/MaxGameDesignPoints * 100;
            float codePercentage = ProgrammingPoints/MaxProgrammingPoints * 100;
            float artPercentage = ArtPoints/MaxArtPoints * 100;
            float soundPercentage = SoundPoints/MaxSoundPoints * 100;
            Log.Add($"Game, unfortunately, couldn't be completed in time. Here's what you managed to complete: \nGame Design: {gdPercentage}%\nProgramming: {codePercentage}%\nArt: {artPercentage}%\nSound: {soundPercentage}%");
        }
        GameLog.text = Log.GetLog();
    }

    public bool ChangeMoney(int value){
        print(Money + value);
        if(Money + value < 0) return false;
        Money += value;
        return true;
    }
}
