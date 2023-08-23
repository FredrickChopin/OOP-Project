using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using static Project.GlobalVars;
using System.ComponentModel;

namespace Project
{

    static class GlobalVars
    {
        public static BindingList<Room> rooms = null;
        public static string roomsMDLPath = "Serialized\\Rooms.mdl";
    }

    static class Utilities
    {

        public static void ValidateProperty<T>(T property, string message, Predicate<T> validationFunction)
        {
            if (!validationFunction(property))
            {
                throw new ArgumentException(message);
            }
        }

        public static bool IsInt(string text)
        {
            return int.TryParse(text, out _);
        }

        public static bool IsDouble(string text)
        {
            return double.TryParse(text, out _);
        }

        public static void SaveObject<T>(T objectToSave, string path)
        {
            string directory = Path.GetDirectoryName(path);

            //create the directory of the path (doesn't hurt if the directory already exists)
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, objectToSave);
            }
        }

        public static object LoadObject(string path)
        {
            //Don't forget to cast to the needed type when calling the function
            try
            {
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    return binaryFormatter.Deserialize(stream);
                }
            }
            catch
            {
                return null;
            }
        }

        public static void LoadRooms()
        {
            try
            {
                rooms = (BindingList<Room>)LoadObject(roomsMDLPath);
            }
            catch
            {
                MessageBox.Show("Invalid mdl path");
            }
            if (rooms == null)
            {
                rooms = new BindingList<Room>();
            }
        }

        public static void SaveRooms()
        {
            SaveObject(rooms, roomsMDLPath);
        }

    }

}
