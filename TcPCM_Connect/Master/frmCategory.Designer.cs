﻿namespace TcPCM_Connect
{
    partial class frmCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundBorderPanel2 = new TcPCM_Connect.RoundBorderPanel();
            this.btn_ExcelCreate = new CustomControls.RJControls.RJButton();
            this.searchButton1 = new TcPCM_Connect.Controller.SearchButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Classification = new CustomControls.RJControls.RJComboBox();
            this.btn_Configuration = new CustomControls.RJControls.RJButton();
            this.btn_Save = new CustomControls.RJControls.RJButton();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.btn_Create = new CustomControls.RJControls.RJButton();
            this.roundBorderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundBorderPanel2.BackgroundColor = System.Drawing.Color.White;
            this.roundBorderPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundBorderPanel2.BorderRadius = 10;
            this.roundBorderPanel2.BorderSize = 1;
            this.roundBorderPanel2.Controls.Add(this.btn_ExcelCreate);
            this.roundBorderPanel2.Controls.Add(this.searchButton1);
            this.roundBorderPanel2.Controls.Add(this.label2);
            this.roundBorderPanel2.Controls.Add(this.cb_Classification);
            this.roundBorderPanel2.Controls.Add(this.btn_Configuration);
            this.roundBorderPanel2.Controls.Add(this.btn_Save);
            this.roundBorderPanel2.Controls.Add(this.dgv_Category);
            this.roundBorderPanel2.Controls.Add(this.btn_Create);
            this.roundBorderPanel2.IsFill = true;
            this.roundBorderPanel2.Location = new System.Drawing.Point(5, 4);
            this.roundBorderPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Size = new System.Drawing.Size(1061, 615);
            this.roundBorderPanel2.TabIndex = 62;
            // 
            // btn_ExcelCreate
            // 
            this.btn_ExcelCreate.AllowDrop = true;
            this.btn_ExcelCreate.BackColor = System.Drawing.Color.White;
            this.btn_ExcelCreate.BackgroundColor = System.Drawing.Color.White;
            this.btn_ExcelCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_ExcelCreate.BorderRadius = 5;
            this.btn_ExcelCreate.BorderSize = 1;
            this.btn_ExcelCreate.FlatAppearance.BorderSize = 0;
            this.btn_ExcelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ExcelCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_ExcelCreate.Location = new System.Drawing.Point(769, 23);
            this.btn_ExcelCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExcelCreate.Name = "btn_ExcelCreate";
            this.btn_ExcelCreate.Size = new System.Drawing.Size(99, 39);
            this.btn_ExcelCreate.TabIndex = 66;
            this.btn_ExcelCreate.Text = "엑셀 Export";
            this.btn_ExcelCreate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_ExcelCreate.UseVisualStyleBackColor = false;
            this.btn_ExcelCreate.Click += new System.EventHandler(this.btn_ExcelCreate_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.BackColor = System.Drawing.Color.Transparent;
            this.searchButton1.DetailSearchButtonBackColor = System.Drawing.Color.White;
            this.searchButton1.Location = new System.Drawing.Point(209, 24);
            this.searchButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.PanelBackColor = System.Drawing.Color.Transparent;
            this.searchButton1.Size = new System.Drawing.Size(389, 38);
            this.searchButton1.TabIndex = 65;
            this.searchButton1.text = "";
            this.searchButton1.TextBoxBackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton1.SearchButtonClick += new System.EventHandler(this.searchButton1_SearchButtonClick_1);
            this.searchButton1.DetailSearchButtonClick += new System.EventHandler(this.searchButton1_DetailSearchButtonClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "분류 : ";
            // 
            // cb_Classification
            // 
            this.cb_Classification.BackColor = System.Drawing.Color.White;
            this.cb_Classification.BorderColor = System.Drawing.Color.DimGray;
            this.cb_Classification.BorderSize = 1;
            this.cb_Classification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_Classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Classification.ForeColor = System.Drawing.Color.DimGray;
            this.cb_Classification.IconColor = System.Drawing.Color.DimGray;
            this.cb_Classification.Items.AddRange(new object[] {
            "지역",
            "업종",
            "작업일수",
            "공간 생산 비용",
            "전력단가",
            "임률",
            "단위"});
            this.cb_Classification.ListBackColor = System.Drawing.Color.White;
            this.cb_Classification.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_Classification.Location = new System.Drawing.Point(67, 24);
            this.cb_Classification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Classification.Name = "cb_Classification";
            this.cb_Classification.Padding = new System.Windows.Forms.Padding(1);
            this.cb_Classification.Size = new System.Drawing.Size(136, 38);
            this.cb_Classification.TabIndex = 63;
            this.cb_Classification.Texts = "지역";
            this.cb_Classification.OnSelectedIndexChanged += new System.EventHandler(this.cb_Classification_OnSelectedIndexChanged);
            // 
            // btn_Configuration
            // 
            this.btn_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Configuration.BackColor = System.Drawing.Color.White;
            this.btn_Configuration.BackgroundColor = System.Drawing.Color.White;
            this.btn_Configuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Configuration.BorderRadius = 5;
            this.btn_Configuration.BorderSize = 1;
            this.btn_Configuration.FlatAppearance.BorderSize = 0;
            this.btn_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Configuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Configuration.Location = new System.Drawing.Point(878, 23);
            this.btn_Configuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.Size = new System.Drawing.Size(166, 39);
            this.btn_Configuration.TabIndex = 62;
            this.btn_Configuration.Text = "Configuration 설정 변경";
            this.btn_Configuration.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Configuration.UseVisualStyleBackColor = false;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_Configuration_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AllowDrop = true;
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BackgroundColor = System.Drawing.Color.White;
            this.btn_Save.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.BorderRadius = 5;
            this.btn_Save.BorderSize = 1;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Save.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.Location = new System.Drawing.Point(603, 24);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(55, 39);
            this.btn_Save.TabIndex = 59;
            this.btn_Save.Text = "저장";
            this.btn_Save.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgv_Category
            // 
            this.dgv_Category.AllowUserToAddRows = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgv_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Category.ColumnHeadersHeight = 40;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Category.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Category.EnableHeadersVisualStyles = false;
            this.dgv_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgv_Category.Location = new System.Drawing.Point(26, 78);
            this.dgv_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Category.RowHeadersVisible = false;
            this.dgv_Category.RowHeadersWidth = 32;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Category.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Category.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Category.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Category.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Category.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Category.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Category.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Category.RowTemplate.Height = 32;
            this.dgv_Category.Size = new System.Drawing.Size(1006, 500);
            this.dgv_Category.TabIndex = 61;
            this.dgv_Category.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Category_CellFormatting);
            this.dgv_Category.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Category_CellValueChanged);
            this.dgv_Category.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Category_DataError);
            // 
            // btn_Create
            // 
            this.btn_Create.AllowDrop = true;
            this.btn_Create.BackColor = System.Drawing.Color.White;
            this.btn_Create.BackgroundColor = System.Drawing.Color.White;
            this.btn_Create.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_Create.BorderRadius = 5;
            this.btn_Create.BorderSize = 1;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_Create.Location = new System.Drawing.Point(664, 23);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(99, 39);
            this.btn_Create.TabIndex = 58;
            this.btn_Create.Text = "엑셀 Import";
            this.btn_Create.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 622);
            this.Controls.Add(this.roundBorderPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCategory";
            this.Text = "frmExchange";
            this.Load += new System.EventHandler(this.frmExchange_Load);
            this.roundBorderPanel2.ResumeLayout(false);
            this.roundBorderPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Category;
        private RoundBorderPanel roundBorderPanel2;
        private CustomControls.RJControls.RJButton btn_Create;
        private CustomControls.RJControls.RJButton btn_Save;
        private CustomControls.RJControls.RJButton btn_Configuration;
        private CustomControls.RJControls.RJComboBox cb_Classification;
        private System.Windows.Forms.Label label2;
        private Controller.SearchButton searchButton1;
        private CustomControls.RJControls.RJButton btn_ExcelCreate;
    }
}