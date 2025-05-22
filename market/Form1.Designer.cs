
namespace aKyzMarket
{
    partial class Form1
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
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productBarcod = new System.Windows.Forms.TextBox();
            this.okBTN = new System.Windows.Forms.Button();
            this.xBTN = new System.Windows.Forms.Button();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.soldToday = new System.Windows.Forms.ToolStripMenuItem();
            this.BarcodeMS = new System.Windows.Forms.ToolStripMenuItem();
            this.startBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLAB = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDGV
            // 
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(499, 54);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.Size = new System.Drawing.Size(543, 182);
            this.productsDGV.TabIndex = 0;
            // 
            // orderDGV
            // 
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Location = new System.Drawing.Point(499, 272);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.Size = new System.Drawing.Size(543, 180);
            this.orderDGV.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(480, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // productBarcod
            // 
            this.productBarcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productBarcod.Location = new System.Drawing.Point(12, 311);
            this.productBarcod.Multiline = true;
            this.productBarcod.Name = "productBarcod";
            this.productBarcod.Size = new System.Drawing.Size(281, 46);
            this.productBarcod.TabIndex = 4;
            // 
            // okBTN
            // 
            this.okBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okBTN.Location = new System.Drawing.Point(12, 363);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(281, 35);
            this.okBTN.TabIndex = 6;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // xBTN
            // 
            this.xBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xBTN.Location = new System.Drawing.Point(11, 404);
            this.xBTN.Name = "xBTN";
            this.xBTN.Size = new System.Drawing.Size(281, 35);
            this.xBTN.TabIndex = 7;
            this.xBTN.Text = "X";
            this.xBTN.UseVisualStyleBackColor = true;
            this.xBTN.Click += new System.EventHandler(this.xBTN_Click);
            // 
            // confirmBTN
            // 
            this.confirmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmBTN.Location = new System.Drawing.Point(309, 311);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(183, 63);
            this.confirmBTN.TabIndex = 8;
            this.confirmBTN.Text = "Confirm Order";
            this.confirmBTN.UseVisualStyleBackColor = true;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(499, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Products";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProduct,
            this.soldToday,
            this.BarcodeMS,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newProduct
            // 
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(100, 23);
            this.newProduct.Text = "New Product";
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // soldToday
            // 
            this.soldToday.Name = "soldToday";
            this.soldToday.Size = new System.Drawing.Size(87, 23);
            this.soldToday.Text = "Sold Today";
            this.soldToday.Click += new System.EventHandler(this.soldToday_Click);
            // 
            // BarcodeMS
            // 
            this.BarcodeMS.Name = "BarcodeMS";
            this.BarcodeMS.Size = new System.Drawing.Size(70, 23);
            this.BarcodeMS.Text = "Barcode";
            this.BarcodeMS.Click += new System.EventHandler(this.BarcodeMS_Click);
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBTN.Location = new System.Drawing.Point(309, 377);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(183, 35);
            this.startBTN.TabIndex = 11;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateLAB);
            this.panel1.Location = new System.Drawing.Point(309, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 27);
            this.panel1.TabIndex = 12;
            // 
            // dateLAB
            // 
            this.dateLAB.AutoSize = true;
            this.dateLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLAB.ForeColor = System.Drawing.Color.White;
            this.dateLAB.Location = new System.Drawing.Point(617, 0);
            this.dateLAB.Name = "dateLAB";
            this.dateLAB.Size = new System.Drawing.Size(19, 25);
            this.dateLAB.TabIndex = 0;
            this.dateLAB.Text = "/";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 23);
            this.exit.Text = "EXIT";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBTN.Location = new System.Drawing.Point(309, 414);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(184, 35);
            this.stopBTN.TabIndex = 13;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = true;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1049, 461);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.xBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.productBarcod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderDGV);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aKyzMarket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox productBarcod;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button xBTN;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newProduct;
        private System.Windows.Forms.ToolStripMenuItem soldToday;
        private System.Windows.Forms.ToolStripMenuItem BarcodeMS;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLAB;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Button stopBTN;
    }
}

