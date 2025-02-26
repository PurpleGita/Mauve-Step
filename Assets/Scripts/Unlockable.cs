using UnityEngine;

public class Unlockable : MonoBehaviour
{
    public int unlockableID;
    public int unlockableActionID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock(int id) 
    { 
        if (id == unlockableID) 
        {
            UnlockAction(unlockableActionID); 
        }
    }

    void UnlockAction(int actionID) 
    {
        switch (actionID) {

            case 1:
                Debug.Log("Sliding Down");
                transform.Translate(0, -5, 0);
                break;

            default:
                Debug.Log("Unlock action not found");
                break;
        }
    }
}
