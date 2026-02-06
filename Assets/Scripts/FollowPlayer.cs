using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 thirdPersonOffset;
    public Vector3 firstPersonOffset;
    public Vector3 invertedOffset;
    private bool isFirstPerson = false;
    private Level5Mech level5Mech;


    void Start()
    {
        level5Mech = Object.FindFirstObjectByType<Level5Mech>();
    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 activeOffset;
        bool level5MechActive = level5Mech != null && level5Mech.isInverted;
        if (isFirstPerson == true)
        {
            activeOffset = firstPersonOffset;
        }
        else if (level5MechActive == true)
        {
            activeOffset = invertedOffset;
        }
        else
        {
            activeOffset = thirdPersonOffset;
        }
        transform.position = player.position + activeOffset;
    }
    public void SetFirstPerson(bool value)
    {
        isFirstPerson = value;
    }
}
