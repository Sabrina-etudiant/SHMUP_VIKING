using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Leveloader : MonoBehaviour
{
    public void Level()
    {
        SceneManager.LoadScene ("GamePlay");
    }
 
}
