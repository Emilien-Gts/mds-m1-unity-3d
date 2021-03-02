using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject player;
    public GameObject global;
    private AnimateTrump animateTrump;
    private Global globalScript;

    void Start()
    {
        animateTrump = player.GetComponent<AnimateTrump>();
        globalScript = global.GetComponent<Global>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) {
            globalScript.resetPosition();
        }
    }
}