using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlockable : MonoBehaviour
{
    public int unlockableID;
    public int unlockableActionID;
    public string sceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveDownSlowly(float speed)
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
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
       
                MoveDownSlowly(9f);
                break;

            default:
              
                break;
        }
    }
}
