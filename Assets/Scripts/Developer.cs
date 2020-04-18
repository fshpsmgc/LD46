using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DevStats{
    public int GameDesignSkill;
    public int ProgrammingSkill;
    public int ArtSkill;
    public int SoundSkill;

    public float Delay;
    public int Budget;

    public float maxDelay;
    public int maxPoints;

    //TODO: Make it properly
    //Delay = maxDelay - Point
    public void Generate() {
        Delay = maxDelay;
        for(int i = 0; i < maxPoints; i++){
            int skill = Random.Range(0,6);
            switch(skill){
                case 0:
                    GameDesignSkill++;
                    break;
                case 1:
                    ProgrammingSkill++;
                    break;
                case 2:
                    ArtSkill++;
                    break;
                case 3:
                    SoundSkill++;
                    break;
                case 4:
                    Delay--;
                    break;
                default:
                    Budget += Random.Range(85, 125);
                    break;
            }
        }

        GameDesignSkill = Random.Range(0, 10);
        ProgrammingSkill = Random.Range(0, 10);
        ArtSkill = Random.Range(0, 10);
        SoundSkill = Random.Range(0, 10);
        Delay = Random.Range(1f, 7f);
    }
}

public class Developer : MonoBehaviour
{
    [SerializeField] bool generateStatsOnStart;
    [SerializeField] DevStats stats;
    public static int Count = 0;
    private float timeSinceApplying;
    private GameController controller;
    public string DevName;
    public GameObject Panel;

    void Awake(){
        if(generateStatsOnStart){
            stats.Generate();
            DevName = "DeveloperName";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        Count++;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceApplying += Time.deltaTime;
        if (timeSinceApplying >= stats.Delay) {
            controller.ApplyPoints(stats);
            timeSinceApplying = 0;
        }
    }

    public DevStats GetStats(){
        return stats;
    }

    private void OnDestroy() {
        Destroy(Panel);
    }
}
