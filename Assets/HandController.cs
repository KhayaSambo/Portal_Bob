using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{

public enum HandModelType {Left, Right};
public Transform root; 
public Animator animator; 
public Transform[] fingerBones;
}
