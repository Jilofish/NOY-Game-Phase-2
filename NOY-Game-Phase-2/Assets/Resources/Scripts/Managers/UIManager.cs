using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Collections;


public class UIManager : MonoBehaviour
{
	public string[] DialogText;
	public TMP_Text DialogTextInput;
	public int currentOrder=0;
	public Button OrderCompleteButton;
	public Button Trigger1;
	public Button Trigger2;
	public Button Trigger3;

	void Start()
	{
		DialogTextInput.text = DialogText[currentOrder];
	}
	
	public void incrementOrder()
	{
		currentOrder++;
		DialogTextInput.text = DialogText[currentOrder];
	}
}
