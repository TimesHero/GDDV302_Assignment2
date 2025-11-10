using UnityEngine;


public class LocomotionSMB : StateMachineBehaviour 

{
    private static readonly int xAxisParam = Animator.StringToHash("xAxis");
    private static readonly int yAxisParam = Animator.StringToHash("yAxis");
    private static readonly int isMovingParam = Animator.StringToHash("isMoving");

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        animator.SetBool(isMovingParam, false);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        float xInput = animator.GetFloat(xAxisParam);
        float yInput = animator.GetFloat(yAxisParam);

        float mag = new Vector2(xInput, yInput).magnitude;

        bool isMoving = mag > 0.1f;
        animator.SetBool(isMovingParam, isMoving);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        animator.SetBool(isMovingParam, false);
    }
}

