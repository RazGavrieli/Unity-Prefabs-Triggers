using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class GiveLifeToPlayer : MonoBehaviour {
    [Tooltip("The number of lifes that the player gets")] [SerializeField] int amountOfLifes;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Shield triggered by player");
            other.GetComponent<DestroyOnTrigger2D>().life += amountOfLifes;
            other.GetComponent<DestroyOnTrigger2D>().lifeField.SetNumber(other.GetComponent<DestroyOnTrigger2D>().life);
            Destroy(gameObject);  // Destroy the life icon itself - prevent double-use
        } else {
            Debug.Log("Shield triggered by "+other.name);
        }
    }
}