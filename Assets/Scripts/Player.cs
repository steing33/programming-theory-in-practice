using UnityEngine;

public class Player : Person_base
{
    public override void SayHi() {
        Debug.Log($"nice to meet you, I'm {_name}");
    }

    public override void Attack()
    {
        Debug.Log("as a PLAYER i do massive damage to enemies and 0 damage to NPCs");
    }

    private void Start() {
        // this skips the "default" Start() in Person_base
        Debug.Log("player start - different order from other Person_base classes");
        Attack();
        SayHi();
    }
}
