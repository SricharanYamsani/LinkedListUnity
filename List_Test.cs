using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_Test : MonoBehaviour {

    public GameObject nodePrefab;
    MyLinkedList list;

    void Start () {
        list = gameObject.AddComponent<MyLinkedList>();

        list.nodePrefab = nodePrefab;
        list.Add_Last(1);
        list.Add_Last(2);
        list.Add_First(3);

        //Debug.Log("Above Display");
        list.Display();
        //Debug.Log("Below Display");

        // list.Delete_First();
        //list.Delete_First();
        /*list.Add_Last(2);
        list.Add_Last(3);
        list.Add_Last(4);
        list.Add_Last(5);

        list.Add_First(6);

        list.Add_At(3, 0);
        list.Add_At(9, 0);*/

    }


    void Update () {

        if (Input.GetMouseButtonDown(0))
            Add();

        if (Input.GetMouseButtonDown(1))
            Delete();
	}

    void Add()
    {
        list.Add_Last( 4);
        list.Display();
    }

    void Delete()
    {
        list.Delete_Last();
        list.Display();
    }
}
