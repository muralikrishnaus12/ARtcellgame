using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{ 
    private PlaceIndicator placeIndicator;
    public GameObject objectToPlace;
    private GameObject newPlacedObject;
    public GameObject placebutton;
    public GameObject placementindicator;
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }
    public void ClickToPlace() {
        newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        newPlacedObject.transform.SetPositionAndRotation(newPlacedObject.transform.position, newPlacedObject.transform.rotation);
        placebutton.SetActive(false);
        placementindicator.SetActive(false);
    }
}