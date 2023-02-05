using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBreeder : MonoBehaviour
{
    #region Variables
    // Variables.
    public Plant parent1;
    public Plant parent2;
    #endregion

    #region Unity Methods

    void Start()
    {
        // Make sure nothing is in these slots
        parent1 = null;
        parent2 = null;
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
        if (parent1 == null || parent2 == null) return;

        // Calculate new flower breed.


        // Add to plant manager.
        

        // Set parents to null.
    }
    #endregion
}
