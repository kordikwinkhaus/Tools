using System;
using System.Reflection;
using System.Windows.Forms;

namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	internal class BaseSelector
	{
        protected ToolStripComboBox _combo;

        internal BaseSelector(ToolStripComboBox toolStripCombo)
        {
            _combo = toolStripCombo;
            var cmb = toolStripCombo.ComboBox;

            InitInnerCombo(cmb);
        }

        protected virtual void InitInnerCombo(ComboBox cmb)
        {
            cmb.DropDownClosed += new EventHandler(cmb_DropDownClosed);
        }

        private void cmb_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = (Control)sender;
                Type ctrlType = typeof(Control);
                MethodInfo mi = ctrlType.GetMethod("OnMouseLeave", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(ctrl, new object[] { e });
            }
            catch
            {
                // ok - metoda se používá pouze pro vynucení vzhledu "po opuštění myši"
            }
        }
	}
}
