
namespace heeehhh
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
            this.hatta = new System.Windows.Forms.Button();
            this.badaa = new System.Windows.Forms.Button();
            this.student_list = new System.Windows.Forms.DataGridView();
            this.std_name = new System.Windows.Forms.TextBox();
            this.std_address = new System.Windows.Forms.TextBox();
            this.milaa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_click = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).BeginInit();
            this.SuspendLayout();
            // 
            // hatta
            // 
            this.hatta.Location = new System.Drawing.Point(33, 168);
            this.hatta.Name = "hatta";
            this.hatta.Size = new System.Drawing.Size(98, 51);
            this.hatta.TabIndex = 0;
            this.hatta.Text = "Remove";
            this.hatta.UseVisualStyleBackColor = true;
            this.hatta.Click += new System.EventHandler(this.hatta_Click);
            // 
            // badaa
            // 
            this.badaa.Location = new System.Drawing.Point(215, 168);
            this.badaa.Name = "badaa";
            this.badaa.Size = new System.Drawing.Size(96, 47);
            this.badaa.TabIndex = 1;
            this.badaa.Text = "Add";
            this.badaa.UseVisualStyleBackColor = true;
            this.badaa.Click += new System.EventHandler(this.badaa_Click);
            // 
            // student_list
            // 
            this.student_list.AllowUserToAddRows = false;
            this.student_list.AllowUserToDeleteRows = false;
            this.student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stdid,
            this.stdname,
            this.stdaddress,
            this.Action});
            this.student_list.Location = new System.Drawing.Point(376, 6);
            this.student_list.Name = "student_list";
            this.student_list.ReadOnly = true;
            this.student_list.RowHeadersWidth = 51;
            this.student_list.RowTemplate.Height = 24;
            this.student_list.Size = new System.Drawing.Size(647, 531);
            this.student_list.TabIndex = 4;
            this.student_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_list_CellClick_1);
            // 
            // std_name
            // 
            this.std_name.Location = new System.Drawing.Point(83, 12);
            this.std_name.Multiline = true;
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(281, 45);
            this.std_name.TabIndex = 5;
            this.std_name.TextChanged += new System.EventHandler(this.std_name_TextChanged);
            // 
            // std_address
            // 
            this.std_address.Location = new System.Drawing.Point(83, 78);
            this.std_address.Multiline = true;
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(281, 49);
            this.std_address.TabIndex = 6;
            // 
            // milaa
            // 
            this.milaa.Location = new System.Drawing.Point(33, 246);
            this.milaa.Name = "milaa";
            this.milaa.Size = new System.Drawing.Size(98, 50);
            this.milaa.TabIndex = 7;
            this.milaa.Text = "Edit";
            this.milaa.UseVisualStyleBackColor = true;
            this.milaa.Click += new System.EventHandler(this.milaa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // clear_click
            // 
            this.clear_click.Location = new System.Drawing.Point(215, 245);
            this.clear_click.Name = "clear_click";
            this.clear_click.Size = new System.Drawing.Size(98, 51);
            this.clear_click.TabIndex = 10;
            this.clear_click.Text = "clear";
            this.clear_click.UseVisualStyleBackColor = true;
            this.clear_click.Click += new System.EventHandler(this.clear_click_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // stdid
            // 
            this.stdid.HeaderText = "sn";
            this.stdid.MinimumWidth = 6;
            this.stdid.Name = "stdid";
            this.stdid.Width = 125;
            // 
            // stdname
            // 
            this.stdname.HeaderText = "Name";
            this.stdname.MinimumWidth = 6;
            this.stdname.Name = "stdname";
            this.stdname.Width = 125;
            // 
            // stdaddress
            // 
            this.stdaddress.HeaderText = "Address";
            this.stdaddress.MinimumWidth = 6;
            this.stdaddress.Name = "stdaddress";
            this.stdaddress.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 543);
            this.Controls.Add(this.clear_click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.milaa);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.student_list);
            this.Controls.Add(this.badaa);
            this.Controls.Add(this.hatta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hatta;
        private System.Windows.Forms.Button badaa;
        private System.Windows.Forms.DataGridView student_list;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.TextBox std_address;
        private System.Windows.Forms.Button milaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_click;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}

