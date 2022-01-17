using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    //private InputAction leftMouseClick = new InputAction(binding: "<Mouse>/leftButton");
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Using the ScreenToWorldPoint we can convert Input.mousePosition to world space which can then be used to compare against our GameObjects
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Coordinates of click
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            // Performing the Raycast using Physics2D.Raycast
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            // Determine if anything was hit by the click
            if (hit.collider != null &&  (hit.collider.gameObject.name == "Bee (2)" || hit.collider.gameObject.name == "Woodpecker"))
            {
                //Debug.Log(hit.collider.gameObject.name);
                //Debug.Log(inkJSON.text);
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
            else
            {
                Debug.Log("Nothing");
            }
        }
    }
}
