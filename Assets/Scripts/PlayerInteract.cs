using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject interactButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableInteractButton()
    {
        interactButton.SetActive(true);
        Debug.Log("Interact button enabled");
    }

    public void DisableInteractButton()
    {
        interactButton.SetActive(false);
        Debug.Log("Interact button disabled");
    }
}
