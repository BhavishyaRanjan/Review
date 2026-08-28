using System;
using System.Collections.Generic;

public class Node{
    public string word;
    public int freq;
    public Node next;
    public Node prev;
    public Node(string word, int freq = 0){
        this.word = word;
        this.freq = freq;
    }
}
public class Autocomplete{
    Node[] table = new Node[10];
    Node history;
    Node lastHistory;
    Node suggestion;
    Stack<string> undo = new Stack<string>();
    Queue<string> updates = new Queue<string>();
    int GetIndex(string word){
        return Math.Abs(word.GetHashCode()) % 10;
    }
    public void AddWord(string word, int freq){
        int index=GetIndex(word);
        Node current=table[index];
        while(current!=null){
            if (current.word==word){
                current.freq+=freq;
                return;
            }
            current=current.next;
        }
        Node newNode=new Node(word, freq);
        newNode.next=table[index];
        table[index]=newNode;
    }
    int GetFrequency(string word){
        Node current=table[GetIndex(word)];
        while (current!=null){
            if (current.word==word) return current.freq;
            current=current.next;
        }
        return 0;
    }
    public void Search(string word){
        Node newNode = new Node(word);
        if (history == null){
            history = newNode;
            lastHistory = newNode;
        }
        else{
            lastHistory.next = newNode;
            newNode.prev = lastHistory;
            lastHistory = newNode;
        }
    }
    public void UndoAdd(string word){
        undo.Push(word);
    }
    public string Undo(){
        if (undo.Count == 0)
            return null;
        return undo.Pop();
    }

    public void AddUpdate(string word){
        updates.Enqueue(word);
    }
    public void ProcessUpdates(){
        while (updates.Count>0) {
            string word=updates.Dequeue();
            AddWord(word,1);
        }
    }
    public bool Find(string word){
        List<string>words=new List<string>();
        foreach(Node start in table){
            Node current=start;
            while(current!=null){
                words.Add(current.word);
                current=current.next;
            }
        }
        words.Sort();
        int left=0;
        int right=words.Count-1;
        while(left<=right){
            int mid=(left+right)/2;
            if (words[mid]==word)
                return true;
            if (words[mid].CompareTo(word)<0)
                left=mid+1;
            else
                right=mid-1;
        }
        return false;
    }
}

class Program{
    static void Main(){
        Autocomplete a=new Autocomplete();
        a.AddWord("apple",50);
        a.AddWord("application",30);
        a.AddWord("apply",20);
        a.AddWord("banana",40);
        a.Search("apple");
        a.UndoAdd("apple");
        Console.WriteLine("Undo "+a.Undo());
        a.AddUpdate("orange");
        a.ProcessUpdates();
        Console.WriteLine("Found "+a.Find("banana"));
    }
}
