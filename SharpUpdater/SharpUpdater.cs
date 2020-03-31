using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace SharpUpdater
{
    public interface iSharpUpdatable
    {
        string ApplicationName { get; }
        string ApplicationID { get; }

        Assembly ApplicationAssembly { get; }

        Icon ApplicationIcon { get; }

        Uri UpdateXmlLocation { get; }
        Form Context { get; }
    }
}
