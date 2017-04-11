using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class DisableOnVREnabled : MonoBehaviour 
{
	public MonoBehaviour[] components;

	void Awake()
	{
		if (VRDevice.isPresent)
		{
			foreach (var comp in components) 
			{
				comp.enabled = false;
			}
		}
	}
}
