using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public PlantData plantData;
    BoxCollider2D clickMeDaddy;

    [SerializeField] GameObject renderFlowerPrefab;
    [SerializeField] GameObject renderStemPrefab;

    void Start()
    {
        if (plantData == null) {
            // Set default plant
            return;
        }
        clickMeDaddy = GetComponent<BoxCollider2D>();
    }

    public void RenderPlant() {
        var flowerRenderer = renderFlowerPrefab.GetComponent<SpriteRenderer>();
        flowerRenderer.sprite = plantData.flowerSprite;
        flowerRenderer.color = new Color(plantData.flowerColor.r, plantData.flowerColor.g, plantData.flowerColor.b, 255);

        var stemRenderer = renderStemPrefab.GetComponent<SpriteRenderer>();
        stemRenderer.sprite = plantData.stemSprite;
    }

    public void setPlantData(PlantData plantData) {
        this.plantData = plantData;
    }
}
