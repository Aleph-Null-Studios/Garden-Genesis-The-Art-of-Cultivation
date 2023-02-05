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
        userPlants.Add(defaultPlants[0]);
        userPlants.Add(defaultPlants[1]);
    }

    void Start()
    {
    }

    void Update()
    {
            
    }
}
