using UnityEngine;

public class AlarmComponent : MonoBehavior
{
    private void Start()
    {
        GetComponent<GameEventComponent>().Invoke("StartAlarm");
    }
}
