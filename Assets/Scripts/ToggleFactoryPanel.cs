using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFactoryPanel : MonoBehaviour
{
    bool isInView = false;
    public GameObject factoryPanel;
    // Start is called before the first frame update
    void Start()
    {
        factoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            toggle();
        }
    }

    public void toggle(){
        if(isInView){
            factoryPanel.SetActive(false);
            isInView = false;
        }else{
            factoryPanel.SetActive(true);
            isInView = true;
        }
    }
}
