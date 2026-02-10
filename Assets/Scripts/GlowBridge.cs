using UnityEngine;

public class GlowBridge : MonoBehaviour
{
    public Animator swordAnimator;

    // This is the "Magic Function" your Scrollbar will finally see
    public void SetGlow(float value)
    {
        swordAnimator.SetFloat("GlowPower", value);
    }
}