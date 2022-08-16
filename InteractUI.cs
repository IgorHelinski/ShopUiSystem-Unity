using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractUI : MonoBehaviour
{
    public bool inRange;
    public bool UIactive;

    public GameObject shopUI;

    public void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            if (UIactive)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //Lock player Movement Here

        shopUI.SetActive(true);

        Time.timeScale = 0f;
        UIactive = true;
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        //Resume player Movement Here

        shopUI.SetActive(false);

        Time.timeScale = 1f;
        UIactive = false;
    }

    public void Start()
    {
        shopUI.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //Checks if player entred the trigger collider
        {
            inRange = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) //Checks if player exit the trigger collider
        {
            inRange = false;
        }
    }
}
