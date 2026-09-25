using UnityEngine;

public class DeadState : State
{
    public DeadState(PlayerScript player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Player is dead");

        player.sr.color = Color.black;
    }

    public override void Update()
    {
        
    }
}
