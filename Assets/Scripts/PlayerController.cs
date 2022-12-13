using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{ 
    // Start is called before the first frame update
    Rigidbody rb;
    float inputX, inputZ;
    public float speed;
    public GameObject EquipButtonFish;
    public GameObject EquipButtonDog;
    public GameObject EquipButtonTire;
    public GameObject findKohinoor, diamond1, diamond2, diamond3, kohinoor, kohinoorlight, winScreen;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        inputZ = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");

        if (inputZ != 0)
            Move();
        if (inputX != 0)
            Rotate();
        if (diamond1.activeSelf && diamond2.activeSelf && diamond3.activeSelf)
        {
            findKohinoor.SetActive(true);
            kohinoor.SetActive(true);
            kohinoorlight.SetActive(true);
        }
    }
    
    private void Move()
    {
        transform.position += transform.forward * inputZ * 2 * Time.deltaTime;
        
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * 45, 0f));
        
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fish")){
            EquipButtonFish.SetActive(true);
        }
        if (other.gameObject.CompareTag("Dog"))
        {
            EquipButtonDog.SetActive(true);
        }
        if (other.gameObject.CompareTag("Tire"))
        {
            EquipButtonTire.SetActive(true);
        }
        if (other.gameObject.CompareTag("Kohinoor"))
        {
           winScreen.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Fish")){
            EquipButtonFish.SetActive(false);
        }
        if (other.gameObject.CompareTag("Fish"))
        {
            EquipButtonDog.SetActive(false);
        }
        if (other.gameObject.CompareTag("Tire"))
        {
            EquipButtonTire.SetActive(false);
        }
    }

}

