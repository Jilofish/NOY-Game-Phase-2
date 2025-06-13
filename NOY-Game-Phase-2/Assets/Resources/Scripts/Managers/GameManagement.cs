using UnityEngine;

public class GameManagement : MonoBehaviour
{

	public bool isGoAssemblyDone = false;
	public bool isGrowAssemblyDone = false;
	public bool isGlowAssemblyDone = false;
	public UIManager uiManager;

	public void GoFoodDone()
	{
		isGoAssemblyDone = true;
	}
	public void GrowFoodDone()
	{
		isGrowAssemblyDone = true;
	}
	public void GlowFoodDone()
	{
		isGlowAssemblyDone = true;
	}
	void Update()
	{
		checkIfAssemblyDone();
	}
	public void resetBoolValue()
	{
		isGoAssemblyDone = false;
		isGrowAssemblyDone = false;
		isGlowAssemblyDone = false;
		uiManager.Trigger1.gameObject.SetActive(true);
		uiManager.Trigger2.gameObject.SetActive(true);
		uiManager.Trigger3.gameObject.SetActive(true);
	}
	public void checkIfAssemblyDone(){
		if (isGlowAssemblyDone == true && isGoAssemblyDone == true && isGrowAssemblyDone == true)
		{
			uiManager.OrderCompleteButton.gameObject.SetActive(true);
		}
	}
}
