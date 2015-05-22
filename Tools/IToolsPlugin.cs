using System.Windows.Forms;

namespace Tools
{
    public interface IToolsPlugin
    {
        string Name { get; }

        Form CreateWindow(string connString);
    }
}
