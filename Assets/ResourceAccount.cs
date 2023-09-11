using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceAccount : MonoBehaviour
{
    [SerializeField]
    private Dictionary<ResourceDef, Resource> _resources = new();
    [SerializeField]
    private GameObject ResourcePrefab;
    // Start is called before the first frame update
    void Start()
    {
        int x = 0;
        foreach (ResourceDef def in ResourceDef.For.All)
        {
            GameObject resourceObject = Instantiate(ResourcePrefab);
            Resource resource = resourceObject.GetComponent<Resource>();
            resource.Def = def;
            resource.transform.parent = transform;
            resource.transform.localPosition = new(x += 100, 0, 0);
        }
    }
}
