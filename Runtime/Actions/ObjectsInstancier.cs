using UnityEngine;

public class ObjectsInstancier : MonoBehaviour
{
    [System.Serializable]
    private struct ObjectInstance
    {
        public GameObject prefab;
        public Transform transform;
    }

    [SerializeField] private ObjectInstance[] objectInstances;

    public void InstantiateObjects()
    {
        foreach (ObjectInstance instance in objectInstances)
        {
            if (instance.prefab != null)
            {
                GameObject go = Instantiate(instance.prefab);
                if (go != null)
                {
                    go.transform.position = instance.transform.position;
                    go.transform.rotation = instance.transform.rotation;
                    go.transform.localScale = instance.transform.localScale;
                }
            }
        }
    }
}
