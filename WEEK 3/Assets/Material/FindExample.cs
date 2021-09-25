using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FindExample : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
GameObject cube = GameObject.FindWithTag("Cube");
if(cube)
{
cube.transform.localScale = new Vector3(2, 2, 2);
}
}
// Update is called once per frame
void Update()
{
}
}
