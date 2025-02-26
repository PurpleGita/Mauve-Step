using UnityEngine;
using static UnityEditor.PlayerSettings;


public class interactable : MonoBehaviour
{

    public GameObject player;
    public int interactActionID;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the trigger");
            player.GetComponent<PlayerInteract>().EnableInteractButton();
            player.GetComponent<PlayerInteract>().LastInteractableSeen = gameObject;
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

    public void Interact()
    {
        Debug.Log("Interacting with object");
        switch (interactActionID)
        {
            case 1:

                GameObject[] gos;
                gos = GameObject.FindGameObjectsWithTag("Unlockable");

                foreach (GameObject go in gos)
                {
                    go.GetComponent<Unlockable>().Unlock(1);
                }
                break;


            case 2:
                Debug.Log("Interact action 2");
                break;


            case 3:
                Debug.Log("Interact action 3");
                break;


            default:
                Debug.Log("Interact action not found");
                break;
        }
    }

}
