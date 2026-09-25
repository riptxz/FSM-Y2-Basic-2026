using UnityEngine;

public class AttackState : State
{
    public AttackState(PlayerScript player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()  // Put code for functions here
    {
        Debug.Log("Has attacked");

        player.sr.color = new Color(1f, 0.3f, 0.4f);
    }

    public override void Update()  // Check to get out of the states
    {
        if(player.jumpAction.IsPressed())
        {
            sm.ChangeState(sm.jumpState);
        }

        if (player.moveAction.IsPressed())
        {
            sm.ChangeState(sm.runState);
        }
        if(player.interactAction.IsPressed())
        {
            sm.ChangeState(sm.idleState);
        }

        
    }

    public override void Exit()
    {
        base.Exit();
    }


}
