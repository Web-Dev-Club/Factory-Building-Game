using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFactoryPanel : MonoBehaviour
{
    public GameObject FactoryPanel;
    bool isInView = false;
    // Start is called before the first frame update
    void Start()
    {
        FactoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void toggle(){
        if(isInView){
            FactoryPanel.SetActive(false);
            isInView = false;
        }else{
            FactoryPanel.SetActive(true);
            isInView = true;
        }
    }
}
