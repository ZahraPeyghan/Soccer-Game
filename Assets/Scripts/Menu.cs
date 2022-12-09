using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
public void OnePlayer(){
    SceneManager.LoadScene("OnePlayer");
}
public void TwoPlayer(){
    SceneManager.LoadScene("TwoPlayer");
}
}
