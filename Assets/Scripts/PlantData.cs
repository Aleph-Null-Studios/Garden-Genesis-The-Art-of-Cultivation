using UnityEngine;
using System;

[System.Serializable]
public class PlantData
{
	[SerializeField] public string name;
	[SerializeField] public Color flowerColor;
	[SerializeField] public Sprite flowerSprite;
	[SerializeField] public Sprite stemSprite;
	[SerializeField] public int price;
	[SerializeField] public int daysGrown;
	[SerializeField] public int minLifeCycle;
	[SerializeField] public int maxLifeCycle;
	int lifeCycle;
	[SerializeField] float maxSize;
    [SerializeField] float minSize;
    [SerializeField] public float size;
    [SerializeField] float sizeIncrement;

	public PlantData(Color flowerColor, Sprite flowerSprite, Sprite stemSprite, int daysGrown)
	{
		name = RandomizeName();
		this.flowerColor = flowerColor;
		this.flowerSprite = flowerSprite;
		this.stemSprite = stemSprite;
		this.daysGrown = daysGrown;
		this.lifeCycle = UnityEngine.Random.Range(minLifeCycle, maxLifeCycle);
	}

	public string RandomizeName()
    {
		string[] plantfirstNames = { "Sunny", "Green", "Leafy","Fruity","Fruitful","Wild","SUNY", "Daisy"};
		string[] plantlastNames = { "Morrisville", "Greens", "Lily", "Rose", "Poppy", "Maple", "Oak", "Tiger" };
        System.Random random = new System.Random();

		string plantName1 = plantfirstNames[random.Next(plantfirstNames.Length)];
		string plantName2 = plantlastNames[random.Next(plantlastNames.Length)];

		string plantName = plantName1 + " " + plantfirstNames; 

		return plantName;
    }

	public float GetGrowthStage()
    {
		// Get the growth stage decidest
		return 1;
    }

	public int GetPlantPrice() {
		return price;
	}

	// Increment the age of the plant by number of days passed by DateController.cs
	public bool IncrementPlantAge(int days) {
		if (lifeCycle == 0) {
			lifeCycle = UnityEngine.Random.Range(minLifeCycle, maxLifeCycle);
			Debug.Log(lifeCycle);
		}

		daysGrown += days;

		if (daysGrown > lifeCycle) {
			return true;
		}
		return false;
	}
}