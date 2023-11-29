using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpMemory : MonoBehaviour
{
    public InputActionAsset actions;
    private InputAction collectMemory;
    public float pickUpRange = 5f;
    public List<GameObject> foundMemory;
    public MemoriesManager memoriesManager;

    /*
    public GameObject memory1;
    public GameObject memory2;
    public GameObject memory3;
    public GameObject memory4;
    */

    void OnEnable()
    {
        actions.FindActionMap("Player").Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("Player").Disable();
    }

    void Awake()
    {
        collectMemory = actions.FindActionMap("Player").FindAction("Memory");
    }

    void Update()
    {
        if (collectMemory.IsPressed())
        {
            RaycastHit hit;
            Debug.Log($"Screen: {Screen.width}x{Screen.height}");
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2));
            if (Physics.Raycast(ray, out hit, pickUpRange))
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 10f);
                Debug.Log($"{hit.collider.name}");
                GameObject found = hit.collider.gameObject;
                if (foundMemory.Contains(found))
                {
                print(found.name);
                    MemoryFound(found);
                }
            }
        }
    }

    public void MemoryFound(GameObject memory)
    {
        DissolveMemory dissolveMemory = memory.GetComponent<DissolveMemory>();
        dissolveMemory.Dissolve();
        
        memoriesManager.MemoryPickedUp();
    }

}
