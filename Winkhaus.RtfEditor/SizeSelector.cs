using System.Windows.Forms;

namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	internal class SizeSelector : BaseSelector
	{
        private int[] _sizes;

        internal SizeSelector(ToolStripComboBox toolStripCombo)
            : base(toolStripCombo)
        {
            _sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };

            for (int i = 0; i < _sizes.Length; i++)
            {
                _combo.Items.Add(_sizes[i].ToString());
            }
        }

        internal int GetDefaultSize()
        {
            return 10;
        }

        internal int GetSelectedSize()
        {
            if (_combo.SelectedIndex != -1)
            {
                return _sizes[_combo.SelectedIndex];
            }
            else
            {
                return GetDefaultSize();
            }
        }

        internal void TrySelectSize(int size)
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                if (_sizes[i] == size)
                {
                    _combo.SelectedIndex = i;
                    return;
                }
            }

            _combo.SelectedIndex = -1;
        }
    }
}
