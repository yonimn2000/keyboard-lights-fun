using System.Collections.Generic;
using System.Xml;

namespace YonatanMankovich.KeyboardLightsFun
{
    public static class PatternsFileManager
    {
        public static string PathToFile { get; set; } = "Patterns.xml";

        public static void SavePatterns(IList<Pattern> patterns)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode patternsNode = doc.CreateElement("Patterns");
            doc.AppendChild(patternsNode);

            foreach (Pattern pattern in patterns)
            {
                XmlNode patternNode = doc.CreateElement("Pattern");
                XmlAttribute patternAttribute = doc.CreateAttribute("name");
                patternAttribute.Value = pattern.Name;
                patternNode.Attributes.Append(patternAttribute);

                foreach (ToggleableKeyStates keyStates in pattern.StatesList)
                {
                    XmlNode statesNode = doc.CreateElement("States");

                    XmlAttribute numLockAttribute = doc.CreateAttribute("numLock");
                    numLockAttribute.Value = keyStates.NumLockState.ToString().ToLower();
                    statesNode.Attributes.Append(numLockAttribute);

                    XmlAttribute capsLockAttribute = doc.CreateAttribute("capsLock");
                    capsLockAttribute.Value = keyStates.CapsLockState.ToString().ToLower();
                    statesNode.Attributes.Append(capsLockAttribute);

                    XmlAttribute scrollLockAttribute = doc.CreateAttribute("scrollLock");
                    scrollLockAttribute.Value = keyStates.ScrollLockState.ToString().ToLower();
                    statesNode.Attributes.Append(scrollLockAttribute);

                    patternNode.AppendChild(statesNode);
                }
                patternsNode.AppendChild(patternNode);
            }
            doc.Save(PathToFile);
        }

        public static void LoadPatterns(IList<Pattern> patterns)
        {
            // TODO: remove temporary
            for (int i = 0; i < 10; i++)
                patterns.Add(new Pattern("Pattern #" + i, new List<ToggleableKeyStates>()
                {
                    new ToggleableKeyStates(true,false,false),
                    new ToggleableKeyStates(false,true,false),
                    new ToggleableKeyStates(false,false,true)
                }));
        }
    }
}