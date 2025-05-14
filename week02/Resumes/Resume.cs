using System;

public class Resume
{

    public String _name="";
    public List<Job> _job = new List<Job>();
    String job ="";
    public Resume()
    {

    }

    public void Display()
    {   

        Console.WriteLine($"Name: {_name}\n ");
        
    }

}