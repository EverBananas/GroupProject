using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPopupTrigger : MonoBehaviour
{
    // Disabling the script doesn't stop the trigger events 
    // https://answers.unity.com/questions/1120500/c-disabled-script-still-runs.html
    public bool isEnabled = true;
    // Playing Animation on Trigger in Unity
    // https://www.youtube.com/watch?v=JS4k_lwmZHk
    [SerializeField]
    private Animator animationController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player") && GameManager.instance.playerHasObject == false && isEnabled)
        {
            Debug.Log("triggered");
            animationController.SetBool("PlayerInRange", true);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            animationController.SetBool("PlayerInRange", false);
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("Player") && GameManager.instance.playerHasObject == true)
        {
            animationController.SetBool("PlayerInRange", false);
        }
    }
}
