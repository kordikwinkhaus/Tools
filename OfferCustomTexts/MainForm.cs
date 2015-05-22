using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfferCustomTexts
{
    public partial class MainForm : Form
    {
        private readonly Repository _repository;

        public MainForm(string connString)
        {
            InitializeComponent();

            _repository = new Repository(connString);
        }

        private void cmdNovy_Click(object sender, EventArgs e)
        {
            var frm = new CustomTextEditor(_repository);
            frm.CustomText = new CustomText();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _repository.CreateCustomText(frm.CustomText);
            }
        }
    }
}
