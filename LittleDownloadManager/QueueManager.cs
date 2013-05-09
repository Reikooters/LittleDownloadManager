using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*
 * Original code for testing the base64 stuff:
 * 

// Original string
string str = "http://www.google.com/hello.jpg";
string str2;

// Convert to bytes
byte[] bz = System.Text.Encoding.Unicode.GetBytes(str);

// Convert to base64 string
str2 = Convert.ToBase64String(bz);
Console.WriteLine(str2.Length);
Console.WriteLine(str2);

// Now to go back... convert from base64 string back to bytes
byte[] bz2 = Convert.FromBase64String(str2);

// Convert from bytes back to regular (original) string
string str3 = System.Text.Encoding.Unicode.GetString(bz2);

*/

namespace LittleDownloadManager
{
    struct QueueItem
    {
        public uint priority;
        public string localFilename;
        public string URL;
    }

    class QueueManager
    {
        List<QueueItem> queueData = new List<QueueItem>();

        public QueueManager(string filename)
        {
            load(filename);
            //save();
        }

        private bool load(string filename)
        {
            Console.WriteLine(filename);

            using (BinaryReader b = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                // Variables
                long pos = 0;
                long len = b.BaseStream.Length;
                short ver;
                uint numRecords;
                int stringlen;

                // Get queue file version
                ver = b.ReadInt16();
                pos += sizeof(short);
                if (pos >= len) return false;
                Console.WriteLine(ver);

                // Currently only version 1 supported
                if (ver == 1)
                {
                    // Get number of records in file
                    numRecords = b.ReadUInt32();
                    pos += sizeof(uint);
                    Console.WriteLine(numRecords);

                    // Loop through all records
                    for (int i = 0; i < numRecords; ++i)
                    {
                        if (pos >= len) return false;

                        // Read Priority
                        QueueItem qi = new QueueItem();
                        qi.priority = b.ReadUInt32();
                        Console.WriteLine(qi.priority);
                        pos += sizeof(uint);

                        // Read Local filename
                        stringlen = b.ReadInt32();
                        qi.localFilename = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(System.Text.Encoding.ASCII.GetString(b.ReadBytes(stringlen))));
                        Console.WriteLine(qi.localFilename);
                        pos += sizeof(int) + stringlen;

                        // Read URL
                        stringlen = b.ReadInt32();
                        Console.WriteLine(stringlen);
                        qi.URL = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(System.Text.Encoding.ASCII.GetString(b.ReadBytes(stringlen))));
                        Console.WriteLine(qi.URL);
                        pos += sizeof(int) + stringlen;

                        // Add queue item to the QueueData List
                        queueData.Add(qi);

                        Console.WriteLine(queueData.Count);
                    }
                }
            }

            return true;
        }

        private void save()
        {
            // FIX ME
            using (BinaryWriter b = new BinaryWriter(File.Open("file.bin", FileMode.Create)))
            {
                string str = "http://www.google.com/hello.jpg";
                byte[] bz = System.Text.Encoding.Unicode.GetBytes(str);
                b.Write(bz);
            }
        }

        public void fillTable(frmMain mainForm)
        {
            Console.WriteLine(queueData.Count + " in queue");

            foreach (QueueItem qi in queueData)
            {
                mainForm.addURLToTable(qi.priority, qi.localFilename, qi.URL);
                Console.WriteLine("Yuuuu!");
            }
        }

        public List<QueueItem> getQueueData()
        {
            return queueData;
        }
    }
}
