using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public Transform coinEffect;
    private int cointValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameMaster.currentScore += cointValue;
            var effect = Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, 3);
            Destroy(gameObject);
        }
    }
}
