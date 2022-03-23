using UnityEngine;
using UnityEngine.InputSystem;

public class Point : MonoBehaviour
{
    private Camera cam;//acces prive ne peut utiliser, ou modifier que dans ce script/ Camera= au nom= cam
    private Vector3 maxPos;
    private Vector3 minPos;
    Vector2 inputValue;
    [SerializeField] GameObject maxiPos;
    [SerializeField] GameObject miniPos;
    Rigidbody2D rb;
    [SerializeField] float speed;


    private void Start()
    {
        cam = Camera.main;//cam,"camera"mon nom et recuperer dans Camera.main= nom par défaut
        maxPos = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, 10));
        minPos = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth/2, 0, 10));
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void OnMove(InputAction.CallbackContext obj)
    {
        inputValue = obj.ReadValue<Vector2>();
        
        // inputValue = move;
    }

 
    private void FixedUpdate()
    {
       if (!IsOnHorizontalEdge ())//!= fait le contraire false 
        {
            inputValue.x = 0;
        }

        if (!IsVertical())
        {
            inputValue.y = 0;
        }

      
        var direction = inputValue;
        rb.velocity = direction*speed;
        
    }
    private bool IsVertical()
    {

        if (transform.position.x >= maxPos.x)
            return true;
        return false;

    }

    private bool IsBotton()
    {
        if (transform.position.y <= miniPos.transform.position.y)
            return true;
        return false;
    }

    private bool IsTop()
    {
        if (transform.position.y >= maxiPos.transform.position.y)
            return true;
        return false;
    }

    private bool IsOnHorizontalEdge()
    {
        return IsBotton() || IsTop();
    }


    /* void OnMove()
     {
         player2 = new Vector3();//je cree un nouveau vector 3 
         Vector3 player2Pos = new Vector2();// Vector3 player2Pos et modifier en vector2
         player2Pos.x = cam.pixelWidth;//player2Pos.x=resolusion largeur de l'écran 
         player2Pos.y = cam.pixelHeight;// player2Pos.y=resolution hauteur de l'écran 
         player2 = cam.ScreenToWorldPoint(new Vector3(player2Pos.x, player2Pos.y, 10));//je passe en une position dans le monde/assigne à player2Pos la position 
                                                                                       // dans le monde correspondant à la position sur l'écran player2





     }

 /* private Camera cam;

         void Start()
         {
             cam = Camera.main;
         }

         void OnGUI()
         {
             Vector3 point = new Vector3();// Creer un nouveau vector3
             Event currentEvent = Event.current;//maniere deprecie= code valide mais deconseille= maniere deprecier de recuperer la souris 
             Vector2 mousePos = new Vector2();//= Modifier 

             // Get the mouse position from Event.
             // Note that the y position from Event is inverted.//note que la position en y de Event est inverse 
             mousePos.x = currentEvent.mousePosition.x;//position de la souris en x= recuperation de chaque frame de la pos.souris= accimile position en x 
             mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;//pixelHeight=resolution vertical,Height=Hauteur Width=Largeur 

             //ScreenToWorldPoint= passer une position d'ecran (angle inferieur droit= 0,0) a une position dans le monde =(centre de l'ecran =0,0)

             point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));//assigne à point la position dans le monde correspondant à la position sur l'ecran mousePos 
 10

         }*/
   
}