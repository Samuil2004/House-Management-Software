using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class ComplainsManager
    {
        Complain newComplain;
        private string fileName = "ComplainsFile.dat";
        public ComplainsManager()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectDirectory, fileName);
        }

        public Complain AddComplain(complainCategories category,string description)
        {
            DateTime currentTime = DateTime.Now;
            newComplain = new Complain(currentTime,category, description);
            return newComplain;
        }

        public void SerializeToFiles(Complain complain)
        {
            FileStream fileStream = null;
            try
            {
                List<Complain> complainsSoFar;
                if (DeserializeFromFile() != null)
                {
                    complainsSoFar = DeserializeFromFile();
                    complainsSoFar.Add(complain);
                }
                else
                {
                    complainsSoFar = new List<Complain>();
                    complainsSoFar.Add(complain);
                }
                fileStream = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, complainsSoFar);
                //fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        public List<Complain> DeserializeFromFile()
        {
            List<Complain> complainsInFile = new List<Complain>();
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                FileInfo fileInfo = new FileInfo(fileName);
                if (fileInfo.Length > 0)
                {
                    complainsInFile = (List<Complain>)formatter.Deserialize(fileStream);
                    //fileStream.Close();
                    //return complainsInFile;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
            return complainsInFile;
        }
    }
}
