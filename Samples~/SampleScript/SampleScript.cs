using UnityEngine;

public class SampleScript : MonoBehaviour
{
    private void Start()
    {
        GetComponent<GameEventComponent>().Invoke("StartAlarm");
    }
}
