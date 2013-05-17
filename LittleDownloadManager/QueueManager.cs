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
    class QueueManager
    {
        // 
        class QueueHead
        {
            public string name;
            public List<QueueItem> items = new List<QueueItem>();
        }

        struct QueueItem
        {
            public uint priority;
            public string localFilename;
            public string URL;
        }

        List<QueueHead> queueData = new List<QueueHead>();

        public QueueManager(string filename)
        {
            load(filename);
            save();
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

                // Get queue file version
                ver = b.ReadInt16();
                pos += sizeof(short);
                if (pos >= len) return false;
                Console.WriteLine(ver);

                // Currently only version 1 supported
                if (ver == 1)
                {
                    uint numRecords;
                    int stringlen;

                    // Get number of records in file
                    numRecords = b.ReadUInt32();
                    pos += sizeof(uint);
                    Console.WriteLine(numRecords);

                    QueueHead qh = new QueueHead();
                    qh.name = "Default";

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
                        //qi.URL = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(b.ReadString()));
                        Console.WriteLine(qi.URL);
                        pos += sizeof(int) + stringlen;

                        // Add queue item to the QueueData List
                        qh.items.Add(qi);

                        Console.WriteLine(queueData.Count);
                    }

                    queueData.Add(qh);
                }
                else if (ver == 2)
                {
                    try
                    {
                        uint numCategories;
                        uint numItems;

                        // Get number of categories
                        numCategories = b.ReadUInt32();
                        Console.WriteLine(numCategories);

                        for (int i = 0; i < numCategories; ++i)
                        {
                            QueueHead qh = new QueueHead();

                            // Read category name
                            qh.name = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(b.ReadString()));
                            Console.WriteLine(qh.name);

                            // Read number of items in category
                            numItems = b.ReadUInt32();
                            Console.WriteLine(numItems);

                            for (int j = 0; j < numItems; ++j)
                            {
                                QueueItem qi = new QueueItem();

                                // Read Priority
                                qi.priority = b.ReadUInt32();
                                Console.WriteLine(qi.priority);

                                // Read Local Filename
                                qi.localFilename = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(b.ReadString()));
                                Console.WriteLine(qi.localFilename);

                                // Read URL
                                qi.URL = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(b.ReadString()));
                                Console.WriteLine(qi.URL);

                                // Add item to category
                                qh.items.Add(qi);
                            }

                            // Add category to queue
                            queueData.Add(qh);
                        }
                    }
                    catch (EndOfStreamException e)
                    {
                        Console.WriteLine("{0} caught", e.GetType().Name);
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
                // Write version
                b.Write((short)2);

                // Write number of categories
                b.Write(queueData.Count);

                foreach (QueueHead qh in queueData)
                {
                    // Write name, prefixed with length integer
                    b.Write(Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(qh.name)));

                    // Write number of items in category
                    b.Write(qh.items.Count);

                    foreach (QueueItem qi in qh.items)
                    {
                        // Write item data
                        b.Write(qi.priority);
                        b.Write(Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(qi.localFilename)));
                        b.Write(Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(qi.URL)));
                    }
                }


                //string str = "http://www.google.com/hello.jpg";
                //byte[] bz = System.Text.Encoding.Unicode.GetBytes(str);
                //b.Write(bz);
            }
        }

        public void fillTable(frmMain mainForm)
        {
            Console.WriteLine(queueData.Count + " in queue");

            foreach (QueueHead qh in queueData)
            {
                foreach (QueueItem qi in qh.items)
                {
                    mainForm.addURLToTable(qi.priority, qi.localFilename, qi.URL);
                    Console.WriteLine("Yuuuu!");
                }
            }
        }
    }
}
