using UnityEngine;
using UnityEngine.Events;

public class GameEventComponent : MonoBehaviour
{
    [System.Serializable]
    private struct GameEvent
    {
        public string name;
        public UnityEvent eventCallback;
    }

    [SerializeField] private GameEvent[] events = null;

    public void Invoke(string eventName)
    {
        if (events == null || events.Length == 0)
        {
            Debug.LogError(GetType().Name + " " + gameObject.name + " don't have any registered event");

            return;
        }

        bool found = false;
        foreach (GameEvent ev in events)
        {
            if (ev.name == eventName)
            {
                ev.eventCallback.Invoke();
                break;
            }
        }

        if (!found)
        {
            Debug.LogError("GameEvent '" + eventName + "' not found in " + gameObject.name + " " + GetType().Name);
        }
    }
}
