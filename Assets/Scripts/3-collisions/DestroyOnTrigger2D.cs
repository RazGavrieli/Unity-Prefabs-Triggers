using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will decrease the life of the object, and destroy it when it reaches 0")]
    [SerializeField] string enemyTag;
    [SerializeField] string lifeTag;
    [SerializeField] string youDiedScene;
    [SerializeField] public int life;
    [SerializeField] public NumberField lifeField;


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == enemyTag && enabled && life == 1) {
            life--;
            lifeField.SetNumber(life);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            SceneManager.LoadScene(youDiedScene);
        } else if (other.tag == enemyTag && enabled) {
            life--;
            lifeField.SetNumber(life);
            Destroy(other.gameObject);
        } else if (other.tag == lifeTag && enabled) {
            life++;
            lifeField.SetNumber(life);
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
        
    }

}
