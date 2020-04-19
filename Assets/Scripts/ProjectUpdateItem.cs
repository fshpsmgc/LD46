using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProjectUpdateItem : MonoBehaviour
{
    public string LogName;
    [SerializeField] DevStats bonus;
    [SerializeField] int Boredom;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateProject(){
        GameController controller = GameObject.Find("GameController").GetComponent<GameController>();
        controller.ApplyPoints(bonus);
        controller.BoredomPoints -= Boredom;
        GetComponent<Button>().interactable = false;
        Log.Add($"{LogName} feature was added to the game");
    }
}
