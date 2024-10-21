using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreenApp
{
    public partial class FormNovoProduto : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public string Fabricante { get { return ManufacturerName.Text; } }
        public decimal PrecoCompra { get { return BuyPriceValue.Value; } }
        public decimal PrecoVenda { get { return SellPriceValue.Value; } }

        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void FormNovoProduto_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
