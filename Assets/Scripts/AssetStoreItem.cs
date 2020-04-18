using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetStoreItem : MonoBehaviour
{
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
        controller.ApplyPoints(bonus);
        controller.ChangeMoney(-Cost);
    }
}
