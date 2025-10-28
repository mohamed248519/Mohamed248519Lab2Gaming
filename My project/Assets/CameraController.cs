using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

public Transform Target;
public float Cameraspeed;

//Determine the minimum and maximum values in both directions where the camera can move. This is to stop it
//from showing game edges or things you don't want to appear to the player
public float minX, maxX;
public float minY, maxY;

void FixedUpdate() {
    if(Target != null)
{
Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * Cameraspeed);

float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);

transform.position = new Vector3(ClampX, ClampY, -10f);
}
 }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
