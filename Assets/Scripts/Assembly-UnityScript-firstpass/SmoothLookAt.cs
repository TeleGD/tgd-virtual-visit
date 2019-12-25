using System;
using UnityEngine;

[Serializable]
public class SmoothLookAt : MonoBehaviour
{
	public Transform target;
	public float damping;
	public bool smooth;
}
