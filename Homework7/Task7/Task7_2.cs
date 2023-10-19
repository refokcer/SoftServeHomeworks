using System.Text;

namespace Homework7.Task7;

public static class Task7_2
{
    public static void Execute()
    {
        //Write file path
        const string pathWrite = @"C:\Programming\SoftServe\Files\DirectoryC.txt";

        try 
        {
            using (var sw = new StreamWriter(pathWrite))   
            {
                // Get all directories and files from E drive
                string[] files = Directory.GetFiles(@"E:\", "*.*");
                string[] dirs = Directory.GetDirectories(@"E:\", "*.*");

                // Write directory info to file
                foreach (string dir in dirs)
                {
                    if(dir == @"E:\System Volume Information") continue;
                    
                    var di = new DirectoryInfo(dir);
                    sw.WriteLine($"{di.Name},Directory,{DirSize(di)}");  
                }

                // Write file info to file   
                foreach (string file in files) 
                {
                    FileInfo fi = new FileInfo(file);
                    sw.WriteLine($"{fi.Name},{fi.Extension},{fi.Length}");   
                }
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    private static long DirSize(DirectoryInfo d) 
    {
        // Add file sizes.
        FileInfo[] fis = d.GetFiles();

        long size = fis.Sum(fi => fi.Length);

        // Add subdirectory sizes.
        DirectoryInfo[] dis = d.GetDirectories();

        if(dis.Length>0) size += dis.Sum(DirSize);

        return size;  
    }
}