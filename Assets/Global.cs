using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour
{
    
    public GameObject goal;
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    private AnimateTrump animateTrump1;
    private AnimateTrump animateTrump2;
    private Goal goalScript;
    private MoveBall moveBall;
    private Rigidbody2D moveBallRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        moveBall = ball.GetComponent<MoveBall>();
        moveBallRigidbody = ball.GetComponent<Rigidbody2D>();
        animateTrump1 = player1.GetComponent<AnimateTrump>();
        animateTrump2 = player2.GetComponent<AnimateTrump>();
    }

    // Update is called once per frame
    void Update()
    {
        // Nothing to do here..
    }

    public void resetPosition()
    {
        StartCoroutine(resetPositionWithTime(3.0f));
    } 

    IEnumerator resetPositionWithTime(float time)
    {
        moveBallRigidbody.isKinematic = false;
        moveBallRigidbody.velocity = Vector3.zero;
        yield return new WaitForSeconds (time);
        moveBall.transform.position = moveBall.getInitialPosition();
        animateTrump1.transform.position = animateTrump1.getInitialPosition();
        animateTrump2.transform.position = animateTrump2.getInitialPosition();
    }
}