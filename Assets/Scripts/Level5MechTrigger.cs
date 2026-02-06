using UnityEngine;

public class Level5MechTrigger : MonoBehaviour

{
    public Level5Mech invertion;
   void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            invertion.SecretMech(true);
        }
    }

void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
          invertion.SecretMech(false);  
        }
    }


}
 
