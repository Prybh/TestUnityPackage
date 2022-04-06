using UnityEngine;

public class StartInvoker : MonoBehaviour
{
	public GameObject eventObject;
	public string eventName;
	
	private void Start()
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
