using UnityEngine;

public class ObjectsEnabler : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;

    private void Awake()
    {
        ResetObjects();
    }

    public void EnableObjects()
    {
        SetEnabled(true);
    }

    public void ResetObjects()
    {
        SetEnabled(false);
    }

    private void SetEnabled(bool value)
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.SetActive(value);
        }
    }
}
