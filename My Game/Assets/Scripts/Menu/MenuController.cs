using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 0.5f;

    [Header("Graphics Settings")]
    [SerializeField] private Slider brightnessSlider;
    [SerializeField] private TMP_Text brightnessTextValue = null;
    private float defaultBrightness = 1;

    private int _qualityLevel;
    private float _brightnessLevel;
    private bool _isFullscreen;

    [Header("Confirmation")]
    [SerializeField] private GameObject confirmationPrompt = null;

    [Header("Levels To Load")]
    public string _NewGameLevel;
    public string levelToLoad;
    [SerializeField] private GameObject noSavedGameDialog = null;

    [Header("Resolution Dropdown")]
    public TMP_Dropdown resolutionDropdown;
    private Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();


        List<string> options = new List<string>();

        int currentResolutionIndex = 0;


        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_NewGameLevel);
    }

    public void LoadGameDialogYes()
    {
        SceneManager.LoadScene(levelToLoad);
        /*if (PlayerPrefs.HasKey("SavedLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }*/

        
    }



    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0.0");
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }

    public void SetBrightness(float brightness)
    {
        _brightnessLevel = brightness;
        brightnessTextValue.text = brightness.ToString("0.0");
    }
    public void SetFullScreen(bool isFullscreen)
    {
        _isFullscreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        _qualityLevel = qualityIndex;
    }

    public void GraphicsApply()
    {
        PlayerPrefs.SetFloat("masterBrightness", _brightnessLevel);


        PlayerPrefs.SetInt("masterQuality", _qualityLevel);
        QualitySettings.SetQualityLevel(_qualityLevel);

        PlayerPrefs.SetInt("masterFullscreen", (_isFullscreen ? 1 : 0));
        Screen.fullScreen = _isFullscreen;

        StartCoroutine(ConfirmationBox());
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTextValue.text = defaultVolume.ToString("0.0");
            VolumeApply();
        }
        if (MenuType == "Graphic")
        {
            brightnessSlider.value = defaultBrightness;
        }

    }


    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
