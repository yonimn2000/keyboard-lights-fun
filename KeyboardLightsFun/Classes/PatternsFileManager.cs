using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace YonatanMankovich.KeyboardLightsFun
{
    public static class PatternsFileManager
    {
        public static string PathToFile { get; set; } = "Patterns.klf";

        public static void SavePatterns(List<Pattern> patterns)
        {
            using (Stream fs = new FileStream(PathToFile, FileMode.Create))
                new XmlSerializer(typeof(List<Pattern>)).Serialize(fs, patterns);
        }

        public static void LoadPatterns(ref List<Pattern> patterns)
        {
            if (File.Exists(PathToFile))
                using (FileStream fs = File.OpenRead(PathToFile))
                    patterns = (List<Pattern>)new XmlSerializer(typeof(List<Pattern>)).Deserialize(fs);
        }
    }
}