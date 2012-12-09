using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace APK_Statistics.Utils
{
    public class FileManager
    {
        /// <summary>
        /// Reads file with application's setting in a dictionary.
        /// </summary>
        /// <param name="pathSettingFile">
        /// Path to the file with application's settings.
        /// </param>
        /// <returns>
        /// A dictionary where keys represent the settings' names and values
        /// represent settings values. NULL if file could not been read.
        /// </returns>
        public static Dictionary<string, string> ReadSettingsFile(string pathSettingFile)
        {
            if (!File.Exists(pathSettingFile)) return null;

            Dictionary<string, string> dictSettings = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(pathSettingFile))
            {
                while (!reader.EndOfStream)
                {
                    string input = reader.ReadLine();
                    if (input.Equals(String.Empty)) continue;

                    string[] inputParts = input.Split(' ');
                    if (inputParts.Length != 2) return null;

                    dictSettings.Add(inputParts[0], inputParts[1]);
                }
            }

            return dictSettings;
        }
    }
}
