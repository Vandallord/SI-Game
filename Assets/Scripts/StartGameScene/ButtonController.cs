using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StartGameScene
{
    public class ButtonController : MonoBehaviour
    {
        public void StartGameButton()
        {
            SceneManager.LoadScene("Game");
        }
    }
}