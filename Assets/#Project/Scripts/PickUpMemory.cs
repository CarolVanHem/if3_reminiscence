using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpMemory : MonoBehaviour
{
    public InputActionAsset actions;
    private InputAction collectMemory;
    public float pickUpRange = 5f; 
    public GameObject[] foundMemory;

    public MemoriesManager memoriesManager;

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
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
            {
                if (hit.transform.gameObject.tag == "Memory1")
                {
                    FirstMemoryFound();
                }

                if (hit.transform.gameObject.tag == "Memory2")
                {
                    SecondMemoryFound();
                }

                if (hit.transform.gameObject.tag == "Memory3")
                {
                    ThirdMemoryFound();
                }

                if (hit.transform.gameObject.tag == "Memory4")
                {
                    FourthMemoryFound();
                }
            }
        }
    }

    public void FirstMemoryFound()
    {
        Destroy(foundMemory[0]);
        memoriesManager.MemoryPickedUp();

        //play fragment of memory
    }

    public void SecondMemoryFound()
    {
        Destroy(foundMemory[1]);
        memoriesManager.MemoryPickedUp();

        //play fragment of memory
    }

    public void ThirdMemoryFound()
    {
        Destroy(foundMemory[2]);
        memoriesManager.MemoryPickedUp();

        //play fragment of memory
    }

    public void FourthMemoryFound()
    {
        Destroy(foundMemory[3]);
        memoriesManager.MemoryPickedUp();

        //play fragment of memory
    }

}
