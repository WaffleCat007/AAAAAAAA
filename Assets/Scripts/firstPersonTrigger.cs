using UnityEngine;

public class firstPersonTrigger : MonoBehaviour
{
public FollowPlayer cameraFollow;

void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameraFollow.SetFirstPerson(true);
        }
    }

void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameraFollow.SetFirstPerson(false);
        }
    }


}
