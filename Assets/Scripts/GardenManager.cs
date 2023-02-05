using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GardenManager : MonoBehaviour
{
    // Make instances when the garden is chosen
    // Set plantdata to index of plant manager
    public List<GameObject> gardenPlants;
    [SerializeField] PlantManager plantManager;

    [SerializeField] GameObject GardenUICanvas;
    [SerializeField] TextMeshProUGUI plantName;
    [SerializeField] TextMeshProUGUI plantInfo;
    [SerializeField] Image plantPreview;

    // Start is called before the first frame update
    void Start()
    {
            Debug.Log("I got lotion on my dick rn");
            SetPlant();
    }

    void Update()
    {
        doSomething();    
    }

    void doSomething() {
        if (Input.GetMouseButtonDown (0)) {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            if(hitInfo) {
                Debug.Log(hitInfo.transform.gameObject.name);
                PlantData plantData = hitInfo.transform.gameObject.GetComponent<Plant>().plantData;
                if (plantData.name == "") {
                    Debug.Log("I am disabled");
                    return;
                }

                plantPreview.sprite = plantData.flowerSprite;
                // plantPreview.color = plantData.flowerColor;
                plantPreview.color = new Color(plantData.flowerColor.r, plantData.flowerColor.g, plantData.flowerColor.b, 255);
                plantName.text = plantData.name;

                plantInfo.text = $"Sell Price: {plantData.price}\nDays Grown: {plantData.daysGrown}";
            }
        }
    }

    // Set to an on click event when going to garden.
    // This is a horrible name, too bad!
    public void SetPlant()
    {
        for (int i = 0; i < plantManager.userPlants.Count; i++)
        {
            var temp = gardenPlants[i].GetComponent<Plant>();
            temp.plantData = plantManager.userPlants[i];
            Debug.Log("Im strokin my dick rn" + temp.plantData.name + i);
            temp.RenderPlant();
        }
    }
}
