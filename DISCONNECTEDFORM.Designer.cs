
namespace ADO_NET_PROJECT
{
    partial class DISCONNECTEDFORM
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
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(512, 313);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(190, 23);
            this.btnshow.TabIndex = 25;
            this.btnshow.Text = "SHOW ALL EMPLOYEES";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(418, 172);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(418, 114);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 22;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(337, 298);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(192, 298);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(52, 298);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(202, 114);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(159, 20);
            this.txtid.TabIndex = 18;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(202, 172);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 20);
            this.txtname.TabIndex = 17;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(202, 249);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(159, 20);
            this.txtsalary.TabIndex = 16;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(49, 256);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(49, 13);
            this.lblsalary.TabIndex = 15;
            this.lblsalary.Text = "SALARY";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(49, 179);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(106, 13);
            this.lblempname.TabIndex = 14;
            this.lblempname.Text = "EMPLOYEES NAME";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(49, 114);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(86, 13);
            this.lblempid.TabIndex = 13;
            this.lblempid.Text = "EMPLOYEES ID";
            // 
            // DISCONNECTEDFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Name = "DISCONNECTEDFORM";
            this.Text = "DISCONNECTEDFORM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempid;
    }
}