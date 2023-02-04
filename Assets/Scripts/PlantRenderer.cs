using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantRenderer : MonoBehaviour
{
    #region Variables
    // Variables.
    // The plant to render.
    [SerializeField] public Plant plant;

    [SerializeField] public GameObject renderFlowerPrefab;
    [SerializeField] public GameObject renderStemPrefab;
    [SerializeField] public GameObject renderPotPrefab;
    #endregion

    #region Unity Methods

    void Start()
    {
        RenderPlant();
    }

    void Update()
    {
        
    }

    #endregion

    #region Private Methods
    // Private Methods.
    private void RenderPlant()
    {
        // Make 3 prefabs to place
        var flowerRenderer = renderFlowerPrefab.GetComponent<SpriteRenderer>();
        flowerRenderer.sprite = plant.flowerSprite;
        flowerRenderer.color = new Color(plant.flowerColor.r, plant.flowerColor.g, plant.flowerColor.b, 255);

        
    }

    private void ClearRender()
    {

    }
    #endregion

    #region Public Methods
    // Public Methods.
    
    #endregion
}
