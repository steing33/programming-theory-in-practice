using UnityEngine;

public class NPC : Person_base
{
    public override void Attack()
    {
        Debug.Log("being an NPC sucks. I can't damage anything");
    }
}
