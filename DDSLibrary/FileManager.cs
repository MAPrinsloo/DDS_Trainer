using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSLibrary
{
    public class FileManager
    {
        public FileManager() 
        {

        }
        //--------------------------//
        public bool CreateFile(string FileName)
        {
            bool fileExists = false;
            try
            {
                if (File.Exists(FileName) == false)
                {
                    using (FileStream fs = File.Create(FileName)) 
                    {
                        fileExists = true;
                        return fileExists;        
                    }
                }
                else
                {
                    return fileExists;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                return fileExists;
            }
        }
        //https://stackoverflow.com/questions/1971008/edit-a-specific-line-of-a-text-file-in-c-sharp
        public void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        //


        public bool RecreateFile(string FileName)
        {
            bool fileRecreated = false;
            try
            {
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);

                    using (File.Create(FileName)) 
                    {
                        fileRecreated = true;
                    }

                    return fileRecreated;
                }
                else
                {
                    return fileRecreated;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                return fileRecreated;
            }
        }
    //https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.writeline?view=net-7.0
    public List<String> ReadFromFile(string FileName)
        {
            List<String> fileContents = new List<String>();
            try
            {
                StreamReader sr = new StreamReader(FileName);
                String line;
                line = sr.ReadLine();
                while (line != null) 
                {
                    fileContents.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
            }
            return fileContents;
        }

        public void WriteToFile(string FileName, string ContentToWrite) 
        {
            StreamWriter sw = new StreamWriter(path: FileName,append: true);
            try
            {
                sw.WriteLine(ContentToWrite);
                sw.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
