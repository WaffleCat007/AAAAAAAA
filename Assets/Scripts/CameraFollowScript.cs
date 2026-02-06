using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    private Level5Mech level5Mech;

    void Start()
    {
        level5Mech = Object.FindFirstObjectByType<Level5Mech>();
    }

    void LateUpdate()
    {
        // Følg spilleren
        transform.position = player.position;

        // Oppdater Animator på CHILD (CameraRig)
        if (level5Mech != null && animator != null)
        {
            bool InvertionActive = level5Mech.isInverted;
            animator.SetBool("InvertionActive", InvertionActive);
        }
    }
}