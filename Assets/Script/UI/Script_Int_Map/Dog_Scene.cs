using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dog_Scene : MonoBehaviour
{
    public void OnDog()
    {
        SceneManager.LoadScene("Dog");
    }

}
