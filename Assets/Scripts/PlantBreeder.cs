using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantBreeder : MonoBehaviour
{
    #region Variables
    // Variables.
    public PlantData parent1;
    public PlantData parent2;
    
    PlantManager plantManager;

    public List<GameObject> gardenPlants;

    public GameObject parent1Image;
    public GameObject parent2Image;

    public GameObject breedMenu;
    public GameObject breedBg;
    public GameObject mainMenu;
    public GameObject mainBg;
    #endregion

    #region Unity Methods

    void Start()
    {
        // Make sure nothing is in these slots
        parent1 = null;
        parent2 = null;

        plantManager = GetComponent<PlantManager>();
        //BreedPlant();
    }

    void Update()
    {
        
    }

    #endregion

    #region Private Methods
    // Private Methods.
    
    #endregion

    #region Public Methods
    // Public Methods.
    public void BreedPlant()
    {
        if ((parent1 == null || parent2 == null) || (parent1 == parent2) || (plantManager.userPlants.Count >= 14)) return; //cannot be null or the same
        //figure out what to pass to the baby
        Color newflowerColor = Color.LerpUnclamped(parent1.flowerColor, parent2.flowerColor, Random.Range(.2f, 1.5f));
        Sprite newflowerSprite = parent1.flowerSprite;
        Sprite stemSprite = parent1.stemSprite;

        // Calculate new flower breed.
        PlantData babyPlant = new PlantData(newflowerColor, newflowerSprite, stemSprite, 0);
        // Add to plant manager.
        plantManager.userPlants.Add(babyPlant);
        Debug.Log(babyPlant.flowerColor);

        // Set parents to null.
        parent1 = null;
        parent2 = null;
    }

    public void ShowBreedingMenu()
    {
        GardenManager manager = GetComponent<GardenManager>(); 
        mainMenu.SetActive(false);
        mainBg.SetActive(false);
        breedMenu.SetActive(true);
        breedBg.SetActive(true);
        manager.PopupCard.SetActive(false);
        manager.ClearPlant();

        parent1 = manager.selectedPlant.GetComponent<Plant>().plantData;
        parent1Image.GetComponent<Image>().sprite = parent1.flowerSprite;
        parent1Image.GetComponent<Image>().color = parent1.flowerColor;
        ShowPlants();
    }

    public void HideBreedingMenu()
    {
        mainMenu.SetActive(true);
        mainBg.SetActive(true);
        breedMenu.SetActive(false);
        breedBg.SetActive(false);
        GetComponent<GardenManager>().SetPlant();
        HidePlants();
    }

    void ShowPlants() {
        for (int i = 0; i < plantManager.userPlants.Count; i++)
        {
            var temp = plantManager.userPlants[i];

            gardenPlants[i].GetComponent<Image>().sprite = temp.flowerSprite;
            gardenPlants[i].GetComponent<Image>().color = temp.flowerColor;
            gardenPlants[i].GetComponentInChildren<TextMeshProUGUI>().text = temp.name;

            gardenPlants[i].SetActive(true);
        }
    }

    void HidePlants() {
        for (int i = 0; i < plantManager.userPlants.Count; i++)
        {
            parent1 = null;
            parent2 = null;
            gardenPlants[i].SetActive(false);
        }
    }

    public void ClickPlant(int index) {
        Debug.Log(index);
        parent2 = plantManager.userPlants[index];
        parent2Image.GetComponent<Image>().sprite = parent2.flowerSprite;
        parent2Image.GetComponent<Image>().color = parent2.flowerColor;
    }

    void ClearButtons() {
        parent2Image.GetComponent<Image>().sprite = null;
        parent2Image.GetComponent<Image>().color = Color.white;
    }
    #endregion
}
