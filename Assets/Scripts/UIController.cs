using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject HirePanel;
    [SerializeField] GameObject ProjectPanel;
    [SerializeField] GameObject StorePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
