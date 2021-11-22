using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DuplicateObj : MonoBehaviour
{
    public GameObject sceneObject;
    public GameObject drawTrails;

    void Update(){
        drawTrails = GameObject.FindWithTag("Trail");
        
    }

    
    public void CloneSceneObj(){
        GameObject Clone = Instantiate(sceneObject, new Vector3(0.557f, 0.5f, 0f), sceneObject.transform.rotation);
        Clone.transform.localScale = Clone.transform.localScale / 2;
        float lastPositionx = drawTrails.transform.position.x + 1;
        float lastPositiony = drawTrails.transform.position.y - 0.2f;
        float lastPositionz = drawTrails.transform.position.z - 0.3f;
        GameObject Clone2 = Instantiate(drawTrails, new Vector3(lastPositionx, lastPositiony, lastPositionz), drawTrails.transform.rotation);
        Clone2.transform.localScale = Clone2.transform.localScale / 2;
    }
}