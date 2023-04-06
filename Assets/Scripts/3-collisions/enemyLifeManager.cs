using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class enemyLifeManager : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will decrease the life of the object, and destroy it when it reaches 0")]
    [SerializeField] string enemyTag;
    [SerializeField] public int life;



    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == enemyTag && enabled && life == 1) {
            life--;

            Destroy(other.gameObject);
            Destroy(this.gameObject);

        } else if (other.tag == enemyTag && enabled) {
            life--;

            Destroy(other.gameObject);
        } 
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
        
    }
}