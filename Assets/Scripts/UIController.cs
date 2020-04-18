using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject HirePanel;
    [SerializeField] GameObject ProjectPanel;
    [SerializeField] GameObject StorePanel;

    [SerializeField] Text InfoText;
    [SerializeField] Text MoneyText;
    GameController gameController;
    ProjectController projectController;

    private void Awake() {
        gameController = GetComponent<GameController>();
        projectController = GetComponent<ProjectController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //HACK: This shouldn't be in update
        FillInfoText();
    }

    public void OpenWindow(GameObject window){
        if(window.activeSelf){
            window.SetActive(false);
            return;
        }

        HirePanel.SetActive(false);
        ProjectPanel.SetActive(false);
        StorePanel.SetActive(false);

        window.SetActive(true);
    }
    public void FillInfoText(){
        InfoText.text = $"{projectController.gameName}\n{projectController.GetDevsList()}";
        MoneyText.text = $"Money: ${gameController.Money}";
    }
}
