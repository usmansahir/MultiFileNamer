using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class FileNamer 
{

    private Queue<String> Names;

    /*
     * Takes the change in number, whether the files are to counted up (increment) or down, the base name, and the number of files.
     * */
    public FileNamer(int Change, Boolean Increment, int BaseNumber, ArrayList DirectoryNames, String DirectoryName, int NumberOfFiles, String BaseName = "") 
    {
        Names = new Queue<String>();

        String tempName = "";

        for (int i = 0; i < NumberOfFiles; i++)
        {
            if (Increment)
            {
                tempName = BaseName + ((Change * i) + BaseNumber);
            }
            else
            {
                tempName = BaseName + ((-Change * i) + BaseNumber);
            }
            Names.Enqueue(tempName);
            
        }

        //If no duplicates, continue
        if (CheckNameOk(DirectoryNames))
        {
            foreach (var i in DirectoryNames)
            {
                AssignName(DirectoryName, i.ToString());

            }

        }
        else
        {
            Console.WriteLine("Error, potential name already exist");
            //TODO: change to temporary names, then do it anyways.
        }
            
    }
    /*
     *  Take a file, open, rename to next name. Remove name at front of queue
     * */
    public void AssignName (String DirectoryName, String FileName)
    {
        File.Move(DirectoryName + FileName, DirectoryName + (Names.Peek()));
        Names.Dequeue();
    }

    /*
     * Check For duplicate names, cannot allow another name to exist if we are to rename.
     * */
     public Boolean CheckNameOk(ArrayList list)
    {
        Boolean ErrorFlag = false;
        foreach (var i in list)
        {
            foreach(var j in Names)
            {
                if (String.Compare(i.ToString(),j.ToString()) == 0)
                {
                    ErrorFlag = true;
                    break;
                }

            }
            if (ErrorFlag){
                break;
            }

        }

        if (ErrorFlag) {

            return false;
        }
        return true;
    }
}
