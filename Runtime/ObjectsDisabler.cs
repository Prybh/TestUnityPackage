using UnityEngine;

public class ObjectsDisabler : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;

    private void Awake()
    {
        ResetObjects();
    }

    public void DisableObjects()
    {
        SetEnabled(false);
    }

    public void ResetObjects()
    {
        SetEnabled(true);
    }

    private void SetEnabled(bool value)
    {
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.SetActive(value);
        }
    }
}
