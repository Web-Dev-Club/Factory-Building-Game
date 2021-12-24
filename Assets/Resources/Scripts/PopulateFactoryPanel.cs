using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateFactoryPanel : MonoBehaviour
{
    public GameObject[] factories;
    public GameObject factoryPanel;
    float margin = 30;
    float spriteWidth = 300;
    float spriteHeight = 150;

    public List<GameObject> images = new List<GameObject>();
    public List<string> names = new List<string>();
    public List<GameObject> prefabs = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        /*float xPos = margin;
        float yPos = margin;
        for (int i = 0; i < factories.Length; i++){
            GameObject factoryRawImage = factories[i].GetComponent<UIValues>().factoryRawImage;
            factoryRawImage = Instantiate(factoryRawImage, new Vector3(0,0,0), Quaternion.identity, factoryPanel.transform);
            factoryRawImage.transform.position = new Vector3(xPos, -yPos + factoryPanel.GetComponent<RectTransform>().rect.height, 0);
            xPos += spriteWidth + margin;
            if(xPos + spriteWidth + margin > factoryPanel.GetComponent<RectTransform>().rect.width){
                yPos += margin + spriteHeight;
                xPos = margin;
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
