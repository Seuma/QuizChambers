using UnityEngine;

[System.Serializable]
public struct Line
{
	[TextArea(2, 5)] public string text;
}

[CreateAssetMenu(fileName = "New Dialog", menuName = "Dialog")]
public class Dialog : ScriptableObject
{
	
	public Line[] lines;
}