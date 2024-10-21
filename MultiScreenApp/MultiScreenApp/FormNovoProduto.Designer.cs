namespace MultiScreenApp
{
    partial class FormNovoProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductNameLabel = new Label();
            ManufacturerLabel = new Label();
            BuyPriceLabel = new Label();
            SellPriceLabel = new Label();
            textBoxNome = new TextBox();
            ManufacturerName = new TextBox();
            BuyPriceValue = new NumericUpDown();
            SellPriceValue = new NumericUpDown();
            BtnCancel = new Button();
            BtnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)BuyPriceValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellPriceValue).BeginInit();
            SuspendLayout();
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(12, 42);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(133, 20);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Nome do produto:";
            // 
            // ManufacturerLabel
            // 
            ManufacturerLabel.AutoSize = true;
            ManufacturerLabel.Location = new Point(12, 81);
            ManufacturerLabel.Name = "ManufacturerLabel";
            ManufacturerLabel.Size = new Size(80, 20);
            ManufacturerLabel.TabIndex = 1;
            ManufacturerLabel.Text = "Fabricante:";
            // 
            // BuyPriceLabel
            // 
            BuyPriceLabel.AutoSize = true;
            BuyPriceLabel.Location = new Point(12, 122);
            BuyPriceLabel.Name = "BuyPriceLabel";
            BuyPriceLabel.Size = new Size(125, 20);
            BuyPriceLabel.TabIndex = 2;
            BuyPriceLabel.Text = "Preço de compra:";
            // 
            // SellPriceLabel
            // 
            SellPriceLabel.AutoSize = true;
            SellPriceLabel.Location = new Point(12, 160);
            SellPriceLabel.Name = "SellPriceLabel";
            SellPriceLabel.Size = new Size(114, 20);
            SellPriceLabel.TabIndex = 3;
            SellPriceLabel.Text = "Preço de venda:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(151, 39);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(183, 27);
            textBoxNome.TabIndex = 4;
            // 
            // ManufacturerName
            // 
            ManufacturerName.Location = new Point(151, 78);
            ManufacturerName.Name = "ManufacturerName";
            ManufacturerName.Size = new Size(183, 27);
            ManufacturerName.TabIndex = 5;
            // 
            // BuyPriceValue
            // 
            BuyPriceValue.Location = new Point(151, 120);
            BuyPriceValue.Name = "BuyPriceValue";
            BuyPriceValue.Size = new Size(183, 27);
            BuyPriceValue.TabIndex = 6;
            BuyPriceValue.TextAlign = HorizontalAlignment.Right;
            // 
            // SellPriceValue
            // 
            SellPriceValue.Location = new Point(151, 158);
            SellPriceValue.Name = "SellPriceValue";
            SellPriceValue.Size = new Size(183, 27);
            SellPriceValue.TabIndex = 7;
            SellPriceValue.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(239, 201);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(95, 29);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(151, 201);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(82, 29);
            BtnOK.TabIndex = 8;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // FormNovoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 251);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(SellPriceValue);
            Controls.Add(BuyPriceValue);
            Controls.Add(ManufacturerName);
            Controls.Add(textBoxNome);
            Controls.Add(SellPriceLabel);
            Controls.Add(BuyPriceLabel);
            Controls.Add(ManufacturerLabel);
            Controls.Add(ProductNameLabel);
            MaximumSize = new Size(375, 298);
            MinimumSize = new Size(375, 298);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            Load += FormNovoProduto_Load;
            ((System.ComponentModel.ISupportInitialize)BuyPriceValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellPriceValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductNameLabel;
        private Label ManufacturerLabel;
        private Label BuyPriceLabel;
        private Label SellPriceLabel;
        private TextBox textBoxNome;
        private TextBox ManufacturerName;
        private NumericUpDown BuyPriceValue;
        private NumericUpDown SellPriceValue;
        private Button BtnCancel;
        private Button BtnOK;
    }
}