using UnityEngine;

///<summary>
/// 
///</summary>
[System.Serializable]
public class Plant
{
	public string name;
	public Color flowerColor;
	public Sprite flowerSprite;
	public Sprite stemSprite;
	//public Sprite leafSprite;
	public float size = 1;
	private int dayGrown;
	public int lifeCycle;


	public Plant(Color flowerColor, Sprite flowerSprite, Sprite stemSprite, /*Sprite leafSprite,*/ float size, int daysToGrow, int lifeCycle)
	{
		name = RandomizeName();
		this.flowerColor = flowerColor;
		this.flowerSprite = flowerSprite;
		this.stemSprite = stemSprite;
		//this.leafSprite = leafSprite;
		this.size = ClampSize(size);
		this.dayGrown = daysToGrow; // + DateController.day;
		this.lifeCycle = lifeCycle; // + DateController.day;
	}

	public float ClampSize(float size, float minSize = .1f, float maxSize = 5f)
    {
		return Mathf.Clamp(size, minSize, maxSize);
    }

	public string RandomizeName()
    {
		return "Mine Cocketh and Nuteth";
    }

	public float GetGrowthStage()
    {
		// Get the growth stage decidest
		return 1;
    }
}