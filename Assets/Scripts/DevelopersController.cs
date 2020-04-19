using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevelopersController : MonoBehaviour
{
    
    [SerializeField] float minNewDevsTime;
    [SerializeField] float maxNewDevsTime;
    [SerializeField] int minNewDevs;
    [SerializeField] int maxNewDevs;

    [SerializeField] GameObject DeveloperPrefab;
    [SerializeField] RectTransform DevsList;
    [SerializeField] GameObject ExistingDevPanelPrefab;
    [SerializeField] GameObject NewDevPanelPrefab;

    public Sprite[] DevFaces;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DevSpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DevSpawnTimer(){
        //TODO: While not game over
        while(true){
            DoTheThing();
            float secondsWait = Random.Range(minNewDevsTime,maxNewDevsTime);
            yield return new WaitForSeconds(secondsWait);
        }
    }

    void DoTheThing(){
        DeleteTempDevs();
        int newDevs = Random.Range(minNewDevs, maxNewDevs);
        SpawnTempDevs(newDevs);
        UpdateUI();
    }

    public void DeleteTempDevs(){
        GameObject[] devs = GameObject.FindGameObjectsWithTag("DeveloperTemp");
        for(int i = 0; i < devs.Length; i++){
            Destroy(devs[i].gameObject);
        }
    }

    void SpawnTempDevs(int newDevs){
        for(int i = 0; i < newDevs; i++){
            Developer developer = Instantiate(DeveloperPrefab, transform).GetComponent<Developer>();
            developer.Face = DevFaces[Random.Range(0,DevFaces.Length)];
        }
    }

    public void UpdateUI(){
        for(int i = 0; i < DevsList.transform.childCount; i++){
            Destroy(DevsList.GetChild(i).gameObject);
        }

        GameObject mainDev = GameObject.Find("MainDev");
        GameObject[] devs = GameObject.FindGameObjectsWithTag("Developer");
        GameObject[] newDevs = GameObject.FindGameObjectsWithTag("DeveloperTemp");

        GameObject tmp;
        tmp = Instantiate(ExistingDevPanelPrefab, DevsList);
        tmp.GetComponent<ExistingDevPanel>().Init(mainDev.GetComponent<Developer>());

        foreach(var dev in devs){
            tmp = Instantiate(ExistingDevPanelPrefab, DevsList);
            tmp.GetComponent<ExistingDevPanel>().Init(dev.GetComponent<Developer>());
        }

        foreach(var dev in newDevs){
            tmp = Instantiate(NewDevPanelPrefab, DevsList);
            tmp.GetComponent<NewDevPanel>().Init(dev.GetComponent<Developer>());
        } 
    }

    void ClearUI(){
        for(int i = 0; i < DevsList.transform.childCount; i++){
            Destroy(DevsList.GetChild(i).gameObject);
        }
    }
}
