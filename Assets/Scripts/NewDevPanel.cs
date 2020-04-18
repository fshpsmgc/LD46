using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDevPanel : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Text description;
    Developer referencedDeveloper;

    public void Init(Developer dev){
        referencedDeveloper = dev;
        description.text = $"<b>{dev.DevName}</b>\nGame Design: {dev.GetStats().GameDesignSkill}; Programming: {dev.GetStats().ProgrammingSkill};\nArt: {dev.GetStats().ArtSkill}; Sound: {dev.GetStats().SoundSkill};\nDelay{dev.GetStats().Delay}";
        dev.Panel = gameObject;
    }

    public void HireDeveloper(){
        referencedDeveloper.tag = "Developer";
        GameObject.Find("GameController").GetComponent<DevelopersController>().UpdateUI();
        referencedDeveloper.transform.parent = null;
    }
}
