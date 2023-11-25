using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] Slider volumeSlider;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
    }

    void Update()
    {
        if (gameManager.isGameActive)
        {
            volumeSlider.gameObject.SetActive(false);

        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;

        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");

    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);

    }
}
