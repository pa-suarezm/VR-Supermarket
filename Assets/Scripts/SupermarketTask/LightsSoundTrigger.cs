using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsSoundTrigger : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField] LightType _lightType;
	[SerializeField] AudioType _audioType;

	[Space(20)]

	[Header("Components")]
	[SerializeField] private AudioSource _audioSource;
	[SerializeField] private Light _lightSource;

	[Space(20)]

	[Header("Options")]
	[SerializeField] private Color _lightColor1;
	[SerializeField] private Color _lightColor2;
	[SerializeField] private AudioClip _audioClip1;
	[SerializeField] private AudioClip _audioClip2;

	private void Start()
	{
		_audioSource.loop = true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			_lightSource.color = GetLightColorFromConfig();
			_audioSource.clip = GetAudioFromConfig();

			if ( _audioSource.clip != null )
				_audioSource.Play();

			if (_lightSource.color != Color.black)
				_lightSource.gameObject.SetActive(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			_audioSource.Stop();
			_lightSource.gameObject.SetActive(false);
		}
	}

	private Color GetLightColorFromConfig()
	{
		switch (_lightType )
		{
			case LightType.NO_LIGHT:
				return Color.black;

			case LightType.LIGHT_COLOR_1:
				return _lightColor1;

			case LightType.LIGHT_COLOR_2:
				return _lightColor2;

			default:
				return Color.white;
		}
	}

	private AudioClip GetAudioFromConfig()
	{
		switch (_audioType)
		{
			case AudioType.NO_AUDIO:
				return null;

			case AudioType.AUDIO_CLIP_1:
				return _audioClip1;

			case AudioType.AUDIO_CLIP_2:
				return _audioClip2;

			default:
				return null;
		}
	}
}

public enum LightType
{
	NO_LIGHT,
	LIGHT_COLOR_1,
	LIGHT_COLOR_2
}

public enum AudioType
{
	NO_AUDIO,
	AUDIO_CLIP_1,
	AUDIO_CLIP_2
}
