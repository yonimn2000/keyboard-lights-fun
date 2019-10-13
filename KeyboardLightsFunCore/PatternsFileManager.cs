using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace YonatanMankovich.KeyboardLightsFun
{
    public static class PatternsFileManager
    {
        public static string PathToFile { get; set; } = "Patterns.klf";

        /// <summary> Saves the patterns into the PathToFile specified file path. </summary>
        public static void SavePatterns(List<Pattern> patterns)
        {
            if (patterns.Count > 0)
                using (Stream fs = new FileStream(PathToFile, FileMode.Create))
                    new XmlSerializer(typeof(List<Pattern>)).Serialize(fs, patterns);
        }

        /// <summary> Loads the patterns from the PathToFile specified file path. </summary>
        public static void LoadPatterns(ref List<Pattern> patterns)
        {
            if (File.Exists(PathToFile))
                using (FileStream fs = File.OpenRead(PathToFile))
                    patterns = (List<Pattern>)new XmlSerializer(typeof(List<Pattern>)).Deserialize(fs);
        }
    }
}