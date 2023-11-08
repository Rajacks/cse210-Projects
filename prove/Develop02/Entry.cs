using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First we create the entry class, which will be used to create our Entry object. "Entry" serves to form an object which is formed by the date, the proposal and the user's entry.
public class Entry
{
    //Within the Entry class, we define the three aforementioned aspects. Note: Apparently you can define an appearance in a better way by putting "public string _aspectName;".
    public string _date;
    public string _prompt;
    public string _entry;

    //The next step is the one that I didn't know about, which is to create a constructor class. A construction class are those that do not return anything, nor do we have to put what type of information it returns, instead we only put the word public, the name of the class, followed by some parentheses, in which we put the parameters to receive. In this case I proceed to put the _date, _prompt, _entry. 
    //Note: Remember that every time you enter a parameter, you generally define right there what type of data it is.

    public Entry(string date, string prompt, string entry)
    {
        //Now we define the values of our parameters c; 
        //In this case I put the values of my upper parameters since I want them to be these.
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt} Entry: {_entry}.");
    }

}