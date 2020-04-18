using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProjectUpdateItem : MonoBehaviour
{
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
    }
}
