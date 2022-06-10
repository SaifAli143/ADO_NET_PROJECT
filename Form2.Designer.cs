
namespace ADO_NET_PROJECT
{
    partial class Form2
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
            this.lblcourseid = new System.Windows.Forms.Label();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.txtCOURSE_ID = new System.Windows.Forms.TextBox();
            this.txtCOURSE_NAME = new System.Windows.Forms.TextBox();
            this.txtCOURSE_FEES = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Location = new System.Drawing.Point(58, 71);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(66, 13);
            this.lblcourseid.TabIndex = 0;
            this.lblcourseid.Text = "COURSE ID";
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Location = new System.Drawing.Point(58, 152);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(86, 13);
            this.lblcoursename.TabIndex = 1;
            this.lblcoursename.Text = "COURSE NAME";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Location = new System.Drawing.Point(58, 228);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(82, 13);
            this.lblfees.TabIndex = 2;
            this.lblfees.Text = "COURSE FEES";
            // 
            // txtCOURSE_ID
            // 
            this.txtCOURSE_ID.Location = new System.Drawing.Point(183, 64);
            this.txtCOURSE_ID.Name = "txtCOURSE_ID";
            this.txtCOURSE_ID.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_ID.TabIndex = 3;
            // 
            // txtCOURSE_NAME
            // 
            this.txtCOURSE_NAME.Location = new System.Drawing.Point(183, 145);
            this.txtCOURSE_NAME.Name = "txtCOURSE_NAME";
            this.txtCOURSE_NAME.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_NAME.TabIndex = 4;
            // 
            // txtCOURSE_FEES
            // 
            this.txtCOURSE_FEES.Location = new System.Drawing.Point(183, 221);
            this.txtCOURSE_FEES.Name = "txtCOURSE_FEES";
            this.txtCOURSE_FEES.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_FEES.TabIndex = 5;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(50, 307);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(208, 307);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(605, 61);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(370, 61);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(456, 307);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(145, 23);
            this.btnshow.TabIndex = 11;
            this.btnshow.Text = "SHOW ALL DETAILS";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtCOURSE_FEES);
            this.Controls.Add(this.txtCOURSE_NAME);
            this.Controls.Add(this.txtCOURSE_ID);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblcoursename);
            this.Controls.Add(this.lblcourseid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.TextBox txtCOURSE_ID;
        private System.Windows.Forms.TextBox txtCOURSE_NAME;
        private System.Windows.Forms.TextBox txtCOURSE_FEES;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshow;
    }
}