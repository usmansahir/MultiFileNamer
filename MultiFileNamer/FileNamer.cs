using System;
using System.Collections;
using System.IO;

public class FileNamer 
{

    private Queue Names;

    /*
     * Takes the change in number, whether the files are to counted up (increment) or down, the base name, and the number of files.
     * */
    public FileNamer(int Change, Boolean Increment, String BaseName = "", int BaseNumber, ArrayList* DirectoryNames, String DirectoryName)
    {
        Names = new Queue();

        String tempName = "";

        for (int i = 1; i <= Number; i++)
        {
            if (increment)
            {
                tempName = BaseName + (Change * i) + BaseNumber;
            }
            else
            {
                tempName = BaseName - (Change * i) + BaseNumber;
            }
            Names.Enqueue(tempName);
            
        }

        //If no duplicates, continue
        if (CheckNamesOk(DirectoryNames))
        {
            foreach (var i in *list)
            {
                AssignName(DirectoryName, i);

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
        File.Move(DirectoryName + oldFileName, DirectoryName + Names.Dequeue);
    }

    /*
     * Check For duplicate names, cannot allow another name to exist if we are to rename.
     * */
     public Boolean CheckNameOk(ArrayList* list)
    {
        Boolean ErrorFlag = false;
        foreach (var i in *list)
        {
            foreach(var j in Names)
            {
                if (String.Compare(i,j) = 0)
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
