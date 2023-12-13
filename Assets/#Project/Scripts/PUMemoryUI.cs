using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUMemoryUI : MonoBehaviour
{
    public GameObject openText;
    public GameObject puText;

    public List<GameObject> doors;

    public float pickUpRange = 5f;

    public bool doorClicked = false;

    void Update()
    {

        checkDoor();

        if(doorClicked)
        {
            puText.SetActive(true);
        }
    }

    void OnTriggerEnter ()
    {
        openText.SetActive(true);
    }

    void OnTriggerExit ()
    {

        doorClicked = false;

        openText.SetActive(false);
        puText.SetActive(false);
    }

    void checkDoor()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2));
            if (Physics.Raycast(ray, out hit, pickUpRange))
            {
                GameObject door = hit.collider.gameObject;
                if (doors.Contains(door))
                {
                    doorClicked = true;
                }
            }
        }
    }
}