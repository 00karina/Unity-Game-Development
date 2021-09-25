using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeMover : MonoBehaviour
{
private Rigidbody rb;
private NameManager nm;
// Start is called before the first frame update
void Start()
{
rb = GetComponent<Rigidbody>();
// Add a force to the Rigidbody.
rb.AddForce(Vector3.up * 1000f);
// Get another script attached to this GameObject.
nm = GetComponent<NameManager>();
if (nm != null)
{
Debug.Log("CubeMover - Hello, my name is " + nm.myName);
}
}
// Update is called once per frame
void FixedUpdate()
{
}
}