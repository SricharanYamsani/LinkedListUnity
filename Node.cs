using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour  {

    //public GameObject NodePrefab;
    public int data;
    //public Vector3 position;
    public Node next;

    /*
    void Start()
    {
        next = null;
    }*/
    
    public Node(int data)
    {
        this.data = data;
        //this.position = Vector3.zero;

       // GameObject node = Instantiate(NodePrefab, position, Quaternion.identity);
        next = null;
    }
    
    private void OnMouseOver()
    {
        Debug.Log(data);
    }

}
