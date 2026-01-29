using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 thirdPersonOffset;
    public Vector3 firstPersonOffset;
    private bool isFirstPerson = false;
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 activeOffset = isFirstPerson ? firstPersonOffset : thirdPersonOffset;
        transform.position = player.position + activeOffset;
    }
    public void SetFirstPerson(bool value)
    {
        isFirstPerson = value;
    }
}
