using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBreeder : MonoBehaviour
{
    #region Variables
    // Variables.
    public PlantData parent1;
    public PlantData parent2;
    
    PlantManager plantManager;

    public GameObject breedMenu;
    public GameObject mainMenu;
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
        mainMenu.SetActive(false);
        breedMenu.SetActive(true);
        GetComponent<GardenManager>().PopupCard.SetActive(false);
        GetComponent<GardenManager>().ClearPlant();
    }

    public void HideBreedingMenu()
    {
        mainMenu.SetActive(true);
        breedMenu.SetActive(false);
        GetComponent<GardenManager>().SetPlant();
    }
    #endregion
}
