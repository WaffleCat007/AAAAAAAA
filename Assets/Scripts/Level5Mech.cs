using UnityEngine;

public class Level5Mech : MonoBehaviour
{
    public bool isInverted = false;
    private Vector3 normalGravity = new Vector3(0, -25.81f, 0);
    private Vector3 invertedGravity = new Vector3(0, 25.81f, 0);

    public void SecretMech(bool value)
    {
        isInverted = value;

        if (isInverted)
        {
            Physics.gravity = invertedGravity;
        }
        else
        {
            Physics.gravity = normalGravity;
        }
    }
}