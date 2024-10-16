namespace CAFE_INIZIO
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPRINT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.TransactionsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrNameTb = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.PrPriceTb = new System.Windows.Forms.TextBox();
            this.btnRESET = new System.Windows.Forms.Button();
            this.PrQtyTb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CustIDCb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.btnORDER = new System.Windows.Forms.Button();
            this.btnCOSTUMER = new System.Windows.Forms.Button();
            this.btnPRODUCT = new System.Windows.Forms.Button();
            this.btnEMPLOYEE = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDGV)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnORDER);
            this.panel1.Controls.Add(this.btnCOSTUMER);
            this.panel1.Controls.Add(this.btnPRODUCT);
            this.panel1.Controls.Add(this.btnEMPLOYEE);
            this.panel1.Controls.Add(this.btnHOME);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 471);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPRINT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TotalLbl);
            this.panel3.Controls.Add(this.billDGV);
            this.panel3.Controls.Add(this.TransactionsDGV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ProductsDGV);
            this.panel3.Location = new System.Drawing.Point(94, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 471);
            this.panel3.TabIndex = 8;
            // 
            // btnPRINT
            // 
            this.btnPRINT.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPRINT.Image = global::CAFE_INIZIO.Properties.Resources.printer;
            this.btnPRINT.Location = new System.Drawing.Point(497, 232);
            this.btnPRINT.Name = "btnPRINT";
            this.btnPRINT.Size = new System.Drawing.Size(80, 35);
            this.btnPRINT.TabIndex = 38;
            this.btnPRINT.Text = "PRINT";
            this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPRINT.UseVisualStyleBackColor = false;
            this.btnPRINT.Click += new System.EventHandler(this.btnPRINT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "CUSTOMER BILL";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(606, 238);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(44, 20);
            this.TotalLbl.TabIndex = 8;
            this.TotalLbl.Text = "PHP";
            // 
            // billDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.billDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billDGV.Location = new System.Drawing.Point(404, 30);
            this.billDGV.Name = "billDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.billDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.billDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.billDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.billDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billDGV.Size = new System.Drawing.Size(451, 191);
            this.billDGV.TabIndex = 40;
            this.billDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDGV_CellContentClick);
            // 
            // TransactionsDGV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TransactionsDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.TransactionsDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransactionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionsDGV.Location = new System.Drawing.Point(404, 296);
            this.TransactionsDGV.Name = "TransactionsDGV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TransactionsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TransactionsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.TransactionsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TransactionsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TransactionsDGV.Size = new System.Drawing.Size(463, 172);
            this.TransactionsDGV.TabIndex = 39;
            this.TransactionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionsDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "TRANSACTIONS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "PRODUCTS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.PrNameTb);
            this.panel5.Controls.Add(this.btnSAVE);
            this.panel5.Controls.Add(this.PrPriceTb);
            this.panel5.Controls.Add(this.btnRESET);
            this.panel5.Controls.Add(this.PrQtyTb);
            this.panel5.Location = new System.Drawing.Point(16, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 153);
            this.panel5.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Product Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "PRODUCT";
            // 
            // PrNameTb
            // 
            this.PrNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrNameTb.Location = new System.Drawing.Point(113, 29);
            this.PrNameTb.Name = "PrNameTb";
            this.PrNameTb.Size = new System.Drawing.Size(236, 22);
            this.PrNameTb.TabIndex = 29;
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSAVE.Image = global::CAFE_INIZIO.Properties.Resources.save;
            this.btnSAVE.Location = new System.Drawing.Point(52, 115);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(80, 35);
            this.btnSAVE.TabIndex = 23;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // PrPriceTb
            // 
            this.PrPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrPriceTb.Location = new System.Drawing.Point(113, 85);
            this.PrPriceTb.Name = "PrPriceTb";
            this.PrPriceTb.Size = new System.Drawing.Size(125, 22);
            this.PrPriceTb.TabIndex = 35;
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Turquoise;
            this.btnRESET.Image = global::CAFE_INIZIO.Properties.Resources.reset;
            this.btnRESET.Location = new System.Drawing.Point(142, 115);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(80, 35);
            this.btnRESET.TabIndex = 24;
            this.btnRESET.Text = "RESET";
            this.btnRESET.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // PrQtyTb
            // 
            this.PrQtyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrQtyTb.Location = new System.Drawing.Point(113, 57);
            this.PrQtyTb.Name = "PrQtyTb";
            this.PrQtyTb.Size = new System.Drawing.Size(125, 22);
            this.PrQtyTb.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Controls.Add(this.CustIDCb);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.CustNameTb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(16, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 96);
            this.panel4.TabIndex = 36;
            // 
            // CustIDCb
            // 
            this.CustIDCb.FormattingEnabled = true;
            this.CustIDCb.Location = new System.Drawing.Point(24, 49);
            this.CustIDCb.Name = "CustIDCb";
            this.CustIDCb.Size = new System.Drawing.Size(121, 21);
            this.CustIDCb.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(167, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Customer Name";
            // 
            // CustNameTb
            // 
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(170, 49);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(121, 22);
            this.CustNameTb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer ID";
            // 
            // ProductsDGV
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ProductsDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ProductsDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductsDGV.Location = new System.Drawing.Point(16, 296);
            this.ProductsDGV.Name = "ProductsDGV";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProductsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.ProductsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.Size = new System.Drawing.Size(364, 172);
            this.ProductsDGV.TabIndex = 27;
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellDoubleClick);
            // 
            // btnORDER
            // 
            this.btnORDER.Image = global::CAFE_INIZIO.Properties.Resources.orders;
            this.btnORDER.Location = new System.Drawing.Point(12, 382);
            this.btnORDER.Name = "btnORDER";
            this.btnORDER.Size = new System.Drawing.Size(76, 68);
            this.btnORDER.TabIndex = 5;
            this.btnORDER.Text = "ORDER";
            this.btnORDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnORDER.UseVisualStyleBackColor = true;
            // 
            // btnCOSTUMER
            // 
            this.btnCOSTUMER.Image = global::CAFE_INIZIO.Properties.Resources.costumer;
            this.btnCOSTUMER.Location = new System.Drawing.Point(12, 308);
            this.btnCOSTUMER.Name = "btnCOSTUMER";
            this.btnCOSTUMER.Size = new System.Drawing.Size(76, 68);
            this.btnCOSTUMER.TabIndex = 4;
            this.btnCOSTUMER.Text = "COSTUMER";
            this.btnCOSTUMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCOSTUMER.UseVisualStyleBackColor = true;
            // 
            // btnPRODUCT
            // 
            this.btnPRODUCT.Image = global::CAFE_INIZIO.Properties.Resources.iced_coffee;
            this.btnPRODUCT.Location = new System.Drawing.Point(12, 234);
            this.btnPRODUCT.Name = "btnPRODUCT";
            this.btnPRODUCT.Size = new System.Drawing.Size(76, 68);
            this.btnPRODUCT.TabIndex = 3;
            this.btnPRODUCT.Text = "PRODUCT";
            this.btnPRODUCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPRODUCT.UseVisualStyleBackColor = true;
            // 
            // btnEMPLOYEE
            // 
            this.btnEMPLOYEE.Image = global::CAFE_INIZIO.Properties.Resources.user;
            this.btnEMPLOYEE.Location = new System.Drawing.Point(12, 160);
            this.btnEMPLOYEE.Name = "btnEMPLOYEE";
            this.btnEMPLOYEE.Size = new System.Drawing.Size(76, 68);
            this.btnEMPLOYEE.TabIndex = 2;
            this.btnEMPLOYEE.Text = "EMPLOYEE";
            this.btnEMPLOYEE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEMPLOYEE.UseVisualStyleBackColor = true;
            // 
            // btnHOME
            // 
            this.btnHOME.Image = global::CAFE_INIZIO.Properties.Resources.house;
            this.btnHOME.Location = new System.Drawing.Point(12, 86);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(76, 68);
            this.btnHOME.TabIndex = 1;
            this.btnHOME.Text = "HOME";
            this.btnHOME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHOME.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CAFE_INIZIO.Properties.Resources.Header;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 68);
            this.panel2.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 468);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnORDER;
        private System.Windows.Forms.Button btnCOSTUMER;
        private System.Windows.Forms.Button btnPRODUCT;
        private System.Windows.Forms.Button btnEMPLOYEE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView TransactionsDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrNameTb;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox PrPriceTb;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.TextBox PrQtyTb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.Button btnPRINT;
        private System.Windows.Forms.ComboBox CustIDCb;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}