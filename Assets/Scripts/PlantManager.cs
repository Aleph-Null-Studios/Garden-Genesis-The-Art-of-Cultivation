using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    [SerializeField] GameObject plantPrefab;
    [SerializeField] public List<PlantData> defaultPlants = new List<PlantData>();
    [SerializeField] public List<PlantData> specialPlants = new List<PlantData>();
    [SerializeField] public List<PlantData> userPlants = new List<PlantData>();

    void Awake() {
        int numPlantManagers = FindObjectsOfType<PlantManager>().Length;

        // If there are more than one music players
        if (numPlantManagers > 1) {
            // Kill yourself
            Destroy(gameObject);
        } else {
            // No dont kill yourself your so sexy ahah
            DontDestroyOnLoad(gameObject);
        }

        foreach (var item in defaultPlants)
        {
            userPlants.Add(item);
        }
        {

        }
    }

    public void IncrementPlantAge(int days) {
        // Do stuff
        for (int i = 0; i < userPlants.Count; i++) {
            if (userPlants[i].IncrementPlantAge(days)) {
                DestroyPlant(userPlants[i]);
            }
        }
    }

    public void DestroyPlant(PlantData plant)
    {
        userPlants.Remove(plant);
        GetComponent<GardenManager>().SetPlant();
    }
}
