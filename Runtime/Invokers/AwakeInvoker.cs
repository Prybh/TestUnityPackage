using UnityEngine;

public class AwakeInvoker : MonoBehaviour
{
	public GameObject eventObject;
	public string eventName;
	
	private void Awake()
	{
		if (eventObject != null)
		{
			GameEventComponent gameEvent = eventObject.GetComponent<GameEventComponent>();
			if (gameEvent != null)
			{
				gameEvent.Invoke(eventName);
			}
		}
	}
}
