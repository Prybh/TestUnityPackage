using UnityEngine;

public class ObjectsDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;

    public void DestroyObjects()
    {
		foreach (GameObject gameObject in gameObjects)
        {
            Destroy(gameObject);
        }
    }
}
