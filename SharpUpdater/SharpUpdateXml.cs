using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace SharpUpdater
{
    internal class SharpUpdateXml
    {
        private Version version;
        private Uri uri;
        private string fileName;
        private string md5;
        private string description;
        private string launchArgs;

        internal Version Version { get => version; }
        internal Uri Uri { get => uri; set => uri = value; }
        internal string FileName { get => fileName; set => fileName = value; }
        internal string Md5 { get => md5; set => md5 = value; }
        internal string LaunchArgs { get => launchArgs; set => launchArgs = value; }
        internal string Description { get => description; set => description = value; }
        
        

        internal SharpUpdateXml(Version version, Uri uri, String fileName, string md5, string desc, string launchArgs)
        {
            this.version = version;
            this.uri = uri;
            this.FileName = FileName;
            this.md5 = md5;
            this.description = desc;
            this.LaunchArgs = launchArgs;
        }

        internal bool IsNewerThat(Version version)
        {
            return this.version > version;
        }

        internal static bool ExistsOnServer(Uri location)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(location.AbsoluteUri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                resp.Close();
                return resp.StatusCode == HttpStatusCode.OK;
            }
            catch { return false; }
        }
        internal static SharpUpdateXml Parse(Uri location, string appId)
        {
            Version version = null;
            string url = "", fileName = "", md5 = "", description = "", launchArgs = "";

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(location.AbsoluteUri);

                XmlNode node = doc.DocumentElement.SelectSingleNode("//update[@appId-'" + appId + "']");

                if (node == null)
                    return null;

                version = Version.Parse(node["latestVersion"].InnerText);
                url = node["latestVersionUrl"].InnerText;
                fileName = node["fileName"].InnerText;
                md5 = node["md5"].InnerText;
                description = node["description"].InnerText;
                launchArgs = node["launchArgs"].InnerText;

                return new SharpUpdateXml(version, new Uri(url), fileName, md5, description, launchArgs);

            }
            catch { return null;  }
        }
    }
}
