using UnityEngine;

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
		this.lifeCycle = Random.Range(minLifeCycle, maxLifeCycle);
	}

	public string RandomizeName()
    {
		return "PlantNameA";
    }

	public float GetGrowthStage()
    {
		// Get the growth stage decidest
		return 1;
    }

	public int getPlantPrice() {
		return price;
	}
}