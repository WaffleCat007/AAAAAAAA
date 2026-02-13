using UnityEngine;

public class firstPersonTrigger : MonoBehaviour
{
public FollowPlayer cameraFollow;
public FirstPersonCameraThingy iDontWannaProgramNoMore;


void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameraFollow.SetFirstPerson(true);
            iDontWannaProgramNoMore.SetFirstPerson(true);
        }
    }

void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameraFollow.SetFirstPerson(false);
            iDontWannaProgramNoMore.SetFirstPerson(false);
        }
    }


}
