﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhepHinh
{
    public class Record
    {
        private const string FILE_NAME = "records.rw";
        public static void WriteRecord(string records)
        {
            StreamWriter sw = new StreamWriter(string.Format("{0}/{1}", Application.StartupPath, FILE_NAME), true);
            sw.WriteLine(records);
            sw.Close();
        }

        public static string ReadRecord()
        {
            string records = "";
            StreamReader sr = new StreamReader(string.Format("{0}/{1}", Application.StartupPath, FILE_NAME));
            while (!sr.EndOfStream)
            {
                records += "/n" + sr.ReadLine();
            }
            return records;
        }

        public static List<Winner> ReadRecordList()
        {
            List<Winner> list = new List<GhepHinh.Winner>();
            try
            {
                
                StreamReader sr = new StreamReader(string.Format("{0}/{1}", Application.StartupPath, FILE_NAME));
                while (!sr.EndOfStream)
                {
                    string t = sr.ReadLine();
                    Winner winner = new GhepHinh.Winner();
                    winner.WinnerName = t.Split('|')[0];
                    winner.WinnerTime = t.Split('|')[1];
                    winner.WinnerStep = t.Split('|')[2];
                    list.Add(winner);
                }
                
            }
            catch (Exception)
            {
                
            }
            finally
            {
                
            }
            return list;
        }
    }
}
