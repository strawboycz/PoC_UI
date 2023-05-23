using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SavingOptions : MonoBehaviour
{
	public GameObject soundVolumeSlider;
	public GameObject musicVolumeSlider;
	public List<GameObject> Toggles;


	public void saveOptions()
	{
		PlayerPrefs.SetFloat("Sound volume", soundVolumeSlider.GetComponent<Slider>().value);
		PlayerPrefs.SetFloat("Music volume", musicVolumeSlider.GetComponent<Slider>().value);
		Toggles.ForEach(x=>
			PlayerPrefs.SetInt(x.name,Convert.ToInt32(x.GetComponent<Toggle>().isOn))
			);
	}

	public void loadOptions()
	{
		soundVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Sound volume");
		musicVolumeSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Music volume");
		Toggles.ForEach(x =>
			x.GetComponent<Toggle>().isOn = Convert.ToBoolean(PlayerPrefs.GetInt(x.name))
		);
	}

	void Start()
	{
		loadOptions();
	}
}
