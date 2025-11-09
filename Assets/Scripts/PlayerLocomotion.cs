using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerLocomotion : MonoBehaviour
{
    public Animator animator;
    private readonly int xAxisParam = Animator.StringToHash("xAxis");
    private readonly int yAxisParam = Animator.StringToHash("yAxis");


    void Awake() //runs when GameObject activates
    {
        animator = GetComponent<Animator>(); //searches children until Animator found
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        animator.SetFloat(xAxisParam, horizontalInput);
        animator.SetFloat(yAxisParam, verticalInput);

    }
}
