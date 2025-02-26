using UnityEngine;


public class interactable : MonoBehaviour
{

    public GameObject player;



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the trigger");
            player.GetComponent<PlayerInteract>().EnableInteractButton();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has left the trigger");
            player.GetComponent<PlayerInteract>().DisableInteractButton();
        }
    }
}
