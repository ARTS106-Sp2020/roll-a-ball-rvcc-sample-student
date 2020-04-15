using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    // variables for physics movement
    public float speed;
    private Rigidbody rb;

    //variables for counting and displaying count
    private int count;
    public Text countTextUI;



    // called once before the first update cycle of the game
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetUIText();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }


    // called when the player object collider enters a trigger volume
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetUIText();
        }
    }

    // Move common UI text update to function
    private void SetUIText()
    {
        countTextUI.text = "Count: " + count.ToString();
    }


}


