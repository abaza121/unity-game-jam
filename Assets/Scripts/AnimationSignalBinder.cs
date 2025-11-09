using UnityEngine;

public class AnimationSignalBinder : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private Vector3 previousPosition;
    private int speedHash;
    private int motionSpeedHash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speedHash = Animator.StringToHash("Speed");
        motionSpeedHash = Animator.StringToHash("MotionSpeed");
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        float distance = Vector3.Distance(currentPosition, previousPosition);
        float speed = distance / Time.deltaTime;
        animator.SetFloat(speedHash, speed);
        animator.SetFloat(motionSpeedHash, speed);
        previousPosition = currentPosition;
    }
}
