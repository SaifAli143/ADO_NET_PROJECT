
namespace ADO_NET_PROJECT
{
    partial class DISCONNECTEDCOURSEFORM
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtCOURSE_FEES = new System.Windows.Forms.TextBox();
            this.txtCOURSE_NAME = new System.Windows.Forms.TextBox();
            this.txtCOURSE_ID = new System.Windows.Forms.TextBox();
            this.lblfees = new System.Windows.Forms.Label();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.lblcourseid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(487, 337);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(145, 23);
            this.btnshow.TabIndex = 23;
            this.btnshow.Text = "SHOW ALL DETAILS";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(401, 91);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(636, 91);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(239, 337);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(81, 337);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtCOURSE_FEES
            // 
            this.txtCOURSE_FEES.Location = new System.Drawing.Point(214, 251);
            this.txtCOURSE_FEES.Name = "txtCOURSE_FEES";
            this.txtCOURSE_FEES.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_FEES.TabIndex = 17;
            // 
            // txtCOURSE_NAME
            // 
            this.txtCOURSE_NAME.Location = new System.Drawing.Point(214, 175);
            this.txtCOURSE_NAME.Name = "txtCOURSE_NAME";
            this.txtCOURSE_NAME.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_NAME.TabIndex = 16;
            // 
            // txtCOURSE_ID
            // 
            this.txtCOURSE_ID.Location = new System.Drawing.Point(214, 94);
            this.txtCOURSE_ID.Name = "txtCOURSE_ID";
            this.txtCOURSE_ID.Size = new System.Drawing.Size(100, 20);
            this.txtCOURSE_ID.TabIndex = 15;
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Location = new System.Drawing.Point(89, 258);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(82, 13);
            this.lblfees.TabIndex = 14;
            this.lblfees.Text = "COURSE FEES";
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Location = new System.Drawing.Point(89, 182);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(86, 13);
            this.lblcoursename.TabIndex = 13;
            this.lblcoursename.Text = "COURSE NAME";
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Location = new System.Drawing.Point(89, 101);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(66, 13);
            this.lblcourseid.TabIndex = 12;
            this.lblcourseid.Text = "COURSE ID";
            // 
            // DISCONNECTEDCOURSEFORM
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
            this.Name = "DISCONNECTEDCOURSEFORM";
            this.Text = "DISCONNECTEDCOURSEFORM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtCOURSE_FEES;
        private System.Windows.Forms.TextBox txtCOURSE_NAME;
        private System.Windows.Forms.TextBox txtCOURSE_ID;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lblcourseid;
    }
}