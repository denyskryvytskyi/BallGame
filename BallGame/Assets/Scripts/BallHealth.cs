using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour {

	public int maxFallDistance = -10;
    AudioClip GameOverSound;

    bool isRestarting = false;

    // Update is called once per frame
    void Update () {
		if(transform.position.y <= maxFallDistance)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //FindObjectOfType<AudioManager>().Play("PlayerDeath");  
        }
	}
}
