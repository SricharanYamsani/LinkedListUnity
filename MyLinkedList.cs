using System.Collections;
using System.Collections.Generic;
using UnityEngine;



class MyLinkedList : MonoBehaviour
{
    //public Vector3 startPosition;
    Node head;
    // int count = 0;

    public GameObject nodePrefab;

    public MyLinkedList(GameObject prefab)
    {
        head = null;
        //startPosition = Vector3.zero;
        nodePrefab = prefab;
    }

    public void Add_Last(int data)
    {
        //Node newNode = new Node(data);

        Node newNode = gameObject.AddComponent<Node>();
        newNode.data = data;

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = newNode;
        }
        
    }

    public void Add_First(int data)
    {
        //Node newNode = new Node(data);
        Node newNode = gameObject.AddComponent<Node>();
        newNode.data = data;

        if (head == null)
            head = newNode;
        else
        {
            newNode.next = head;
            head = newNode;
        }

        
    }

    public void Add_At(int pos, int data)
    {
        if (pos == 1)//First Pos
            Add_First(data);
        else
        {
            Node temp = head;
            for (int i = 1; i < pos - 1 && temp != null; i++)
                temp = temp.next;
            if (temp != null)
            {
                //Node newNode = new Node(data);
                Node newNode = gameObject.AddComponent<Node>();
                newNode.data = data;

                newNode.next = temp.next;
                temp.next = newNode;
            }
            else
            {
                Debug.Log("POS EXCEEDS LENGTH - Cannot insert : " + data);         
            }
        }

       
    }

    public void Delete_Last()
    {
        if(head == null)
        {
            return;
        }
        else if(head.next == null)
        {
            // Node temp = head;
            Debug.Log("Node deleted is : " + head.data);
            head = null;     
        }
        else
        {
            Node temp = head;
            while(temp.next.next !=null)
            {
                temp = temp.next;
            }
            Debug.Log("Node deleted is : " + temp.next.data);

            temp.next = null;
        }
    }

    public void Delete_First()
    {
        if (head == null)
        {
            return;
        }
        else if (head.next == null)
        {
            Debug.Log("Node deleted is : " + head.data);
            head = null;
        }
        else
        {
            Node temp = head;
            head = head.next;
            Debug.Log("Node deleted is : " + temp.data);

        }
    }
    
    public void Display()
    {
        int i;
        Node temp = head;
        // Debug.Log("In Display");
        // Debug.Log(temp.data);

        Transform child = transform.GetChild(0);

        for(i = 0; i < child.childCount ;i++)
        {
            Destroy(child.GetChild(i).gameObject);
            Debug.Log("Destroying child");
        }
        i = 0;
        while (temp != null)
        {
           // Debug.Log("In Display");
            GameObject node = Instantiate(nodePrefab, Vector3.zero + i++ * 2 * Vector3.right, Quaternion.identity);
            node.transform.SetParent(transform.GetChild(0));
           // Debug.Log(temp.data + " ");
            temp = temp.next;
        }
    }
}