using System;
using static System.Net.Mime.MediaTypeNames;

public class Student
{
    private int ID;
    private string Name;
    private Test Score;
    public static int Count;

    public Student(int id, string n, int m, int f)
    {
        ID = id;
        Name = n;
        Score = new Test(m, f);
        Count += 1;
    }

    public string GetStudent()
    {
        string str;
        str = "學號: " + ID.ToString();
        str += "\n學生姓名: " + Name;
        str += "\n學生期中考: " + Score.GetMid();
        str += "\n學生期末考: " + Score.GetFinal();
        return str;
    }
}