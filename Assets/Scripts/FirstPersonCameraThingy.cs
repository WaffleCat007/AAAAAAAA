using UnityEngine;

public class FirstPersonCameraThingy : MonoBehaviour


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
        bool level5MechActive = level5Mech != null && level5Mech.isInverted;
        if (isFirstPerson == true)
        {
             transform.position = player.position + firstPersonOffset;
        }

    }
    public void SetFirstPerson(bool value)
    {
        isFirstPerson = value;
    }
}
