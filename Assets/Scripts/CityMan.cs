using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popup;
    public GameObject objectNeeded;
    public GameObject equippedObject;
    public GameObject diamond;
    public GameObject bigDiamond;
    void Start()
    {
        popup.SetActive(false);
    }

    
    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && objectNeeded.activeSelf)
            {
            popup.SetActive(true);
        }
        if (other.gameObject.CompareTag("Player") && !objectNeeded.activeSelf)
        {
            
            Destroy(gameObject);
            equippedObject.SetActive(false);
            bigDiamond.SetActive(true);
            diamond.SetActive(true);
        }
            
    }
    public void OnTriggerExit(Collider other)
    {
        popup.SetActive(false);
    }
}
