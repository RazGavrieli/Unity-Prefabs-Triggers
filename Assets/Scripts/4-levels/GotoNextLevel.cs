using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour {
    [SerializeField] string sceneName;
    [SerializeField] NumberField scoreField;
    [SerializeField] int scoreTarget;


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && scoreField.GetNumber() >= scoreTarget) {
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
            Destroy(other.gameObject);
        }
    }
}
