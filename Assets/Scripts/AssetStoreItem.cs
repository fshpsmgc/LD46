using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssetStoreItem : MonoBehaviour
{
    public string LogName;
    public DevStats bonus;
    public int BoredomBonus;
    public int Cost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyAsset(){
        GameController controller = GameObject.Find("GameController").GetComponent<GameController>();
        if(!controller.ChangeMoney(-Cost)) return;
        controller.ApplyPoints(bonus);
        GetComponent<Button>().interactable = false;
        Log.Add($"Asset {LogName} was bought for ${Cost} and implemented into the game");
    }
}
