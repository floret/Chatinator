namespace Chatinator
{
    partial class frmChat
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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxAnon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(37, 56);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(367, 20);
            this.txbInput.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(426, 54);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post!";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(37, 82);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(367, 329);
            this.lbxOutput.TabIndex = 3;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.Red;
            this.lblTopic.Location = new System.Drawing.Point(23, 36);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(92, 17);
            this.lblTopic.TabIndex = 4;
            this.lblTopic.Text = "Topic: Main";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbxAnon
            // 
            this.cbxAnon.AutoSize = true;
            this.cbxAnon.Location = new System.Drawing.Point(412, 16);
            this.cbxAnon.Name = "cbxAnon";
            this.cbxAnon.Size = new System.Drawing.Size(82, 17);
            this.cbxAnon.TabIndex = 6;
            this.cbxAnon.Text = "Anonamous";
            this.cbxAnon.UseVisualStyleBackColor = true;
            this.cbxAnon.CheckedChanged += new System.EventHandler(this.cbxAnon_CheckedChanged);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.cbxAnon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txbInput);
            this.Name = "frmChat";
            this.Text = "Chatinator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbxAnon;
    }
}

