using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Game Systems/Player /Interact")]
public class Interact : MonoBehaviour
{
    #region Update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            //Create a ray
            Ray _ray;

            // This ray is shooting out from the main cameras point cener of screen
            _ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

            //Create Ray hit info
            RaycastHit _htinfo;

            //if this physics raycast hits sp,etjhing withing 10 units
            if (Physics.Raycast(_ray, out _htinfo, 10))
            {
                #region NPC tag
                // and the hits info is Tagged NPS
                if(_htinfo.collider.tag == "NPC")
                {
                    //That we Hit an NPC
                    Debug.Log("NPC");
                }
                #endregion
                #region Item
                // and the hits info is tagged item
                if (_htinfo.collider.CompareTag("Item"))
                {
                    //That we hit an Item
                    Debug.Log("Item");
                }

                #endregion
            }


        }




    }

    #endregion


}
