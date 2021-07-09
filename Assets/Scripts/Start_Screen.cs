using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Start_Screen : MonoBehaviour
{
    public AudioMixer AudioMixer;
    // Start is called before the first frame update
    public void Starta()
    {
        SceneManager.LoadScene(1);
    }
    public void Vol(float val)
    {
        AudioMixer.SetFloat("Volume",val);
    }
    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
