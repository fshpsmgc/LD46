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

    public float Money;

    [Header("UI")]
    [SerializeField] Slider GameDesignSlider;
    [SerializeField] Slider ProgrammingSlider;
    [SerializeField] Slider ArtSlider;
    [SerializeField] Slider SoundSlider;
    [SerializeField] Slider BoredomSlider;
    // Start is called before the first frame update
    void Start()
    {
        GameDesignSlider.maxValue = MaxGameDesignPoints;
        ProgrammingSlider.maxValue = MaxProgrammingPoints;
        ArtSlider.maxValue = MaxArtPoints;
        SoundSlider.maxValue = MaxSoundPoints;
        BoredomSlider.maxValue = MaxBoredomPoints;
    }

    // Update is called once per frame
    void Update()
    {
        BoredomPoints += Time.deltaTime * (Developer.Count + 1);
        if(BoredomPoints >= MaxBoredomPoints){
            BoredomPoints = 0;
            DeleteDeveloper();
        }

        BoredomSlider.value = BoredomPoints;
    }

    public void ApplyPoints(DevStats stats) {
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

    public void GameOver(){
        print("Game Over");
    }

    public void ChangeMoney(int value){
        Money += value;
    }
}
