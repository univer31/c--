namespace WindowsFormsApplication32
{
    partial class 结果显示
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
            this.components = new System.ComponentModel.Container();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.双选系统DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.双选系统DataSet = new WindowsFormsApplication32.双选系统DataSet();
            this.studentsTableAdapter = new WindowsFormsApplication32.双选系统DataSetTableAdapters.studentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.双选系统DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.双选系统DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(220, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 52);
            this.button6.TabIndex = 48;
            this.button6.Text = "结果显示";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(543, 310);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.双选系统DataSetBindingSource;
            // 
            // 双选系统DataSetBindingSource
            // 
            this.双选系统DataSetBindingSource.DataSource = this.双选系统DataSet;
            this.双选系统DataSetBindingSource.Position = 0;
            // 
            // 双选系统DataSet
            // 
            this.双选系统DataSet.DataSetName = "双选系统DataSet";
            this.双选系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(386, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 52);
            this.button1.TabIndex = 50;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // 结果显示
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Name = "结果显示";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.结果显示_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.双选系统DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.双选系统DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 双选系统DataSet 双选系统DataSet;
        private System.Windows.Forms.BindingSource 双选系统DataSetBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private 双选系统DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}