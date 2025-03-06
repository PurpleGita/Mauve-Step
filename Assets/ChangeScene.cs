
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
   
{
    public string sceneToLoad;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ChanceScene triggered");
            SceneManager.LoadScene(sceneToLoad);
        }

    }
}
