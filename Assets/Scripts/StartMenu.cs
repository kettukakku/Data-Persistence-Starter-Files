using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInput;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SetName()
    {
        SaveManager.Instance.nameText = nameInput.text;
    }
}
