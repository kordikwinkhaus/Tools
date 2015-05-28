using System.Windows.Forms;

namespace Tools
{
    public interface IToolsPlugin
    {
        string Name { get; }

        void Run(string connString);
    }
}
