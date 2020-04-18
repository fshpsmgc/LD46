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

    //TODO: Make it properly
    //Delay = maxDelay - Point
    public void Generate() {
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

    // Start is called before the first frame update
    void Start()
    {
        if(generateStatsOnStart) stats.Generate();
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
}
