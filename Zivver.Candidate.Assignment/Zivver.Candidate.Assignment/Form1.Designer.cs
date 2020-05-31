namespace Zivver.Candidate.Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControl11 = new Zivver.Candidate.Assignment.UI.Controls.UserControl1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Recipients = new System.Windows.Forms.CheckBox();
            this.IsSent = new System.Windows.Forms.CheckBox();
            this.IsZivverMessage = new System.Windows.Forms.CheckBox();
            this.IsDraft = new System.Windows.Forms.CheckBox();
            this.SenderName = new System.Windows.Forms.CheckBox();
            this.MessageId = new System.Windows.Forms.CheckBox();
            this.ConversationId = new System.Windows.Forms.CheckBox();
            this.AccountId = new System.Windows.Forms.CheckBox();
            this.DataToReturn = new System.Windows.Forms.Label();
            this.RecipientNames = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.Color.Blue;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 32);
            this.userControl11.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3894, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filters";
            // 
            // Recipients
            // 
            this.Recipients.AutoSize = true;
            this.Recipients.Location = new System.Drawing.Point(0, 238);
            this.Recipients.Name = "Recipients";
            this.Recipients.Size = new System.Drawing.Size(76, 17);
            this.Recipients.TabIndex = 5;
            this.Recipients.Text = "Recipients";
            this.Recipients.UseVisualStyleBackColor = true;
            this.Recipients.CheckedChanged += new System.EventHandler(this.Recipients_CheckedChanged);
            // 
            // IsSent
            // 
            this.IsSent.AutoSize = true;
            this.IsSent.Location = new System.Drawing.Point(108, 238);
            this.IsSent.Name = "IsSent";
            this.IsSent.Size = new System.Drawing.Size(56, 17);
            this.IsSent.TabIndex = 6;
            this.IsSent.Text = "IsSent";
            this.IsSent.UseVisualStyleBackColor = true;
            this.IsSent.CheckedChanged += new System.EventHandler(this.IsSent_CheckedChanged);
            // 
            // IsZivverMessage
            // 
            this.IsZivverMessage.AutoSize = true;
            this.IsZivverMessage.Location = new System.Drawing.Point(194, 238);
            this.IsZivverMessage.Name = "IsZivverMessage";
            this.IsZivverMessage.Size = new System.Drawing.Size(107, 17);
            this.IsZivverMessage.TabIndex = 7;
            this.IsZivverMessage.Text = "IsZivverMessage";
            this.IsZivverMessage.UseVisualStyleBackColor = true;
            this.IsZivverMessage.CheckedChanged += new System.EventHandler(this.IsZivverMessage_CheckedChanged);
            // 
            // IsDraft
            // 
            this.IsDraft.AutoSize = true;
            this.IsDraft.Location = new System.Drawing.Point(331, 238);
            this.IsDraft.Name = "IsDraft";
            this.IsDraft.Size = new System.Drawing.Size(57, 17);
            this.IsDraft.TabIndex = 8;
            this.IsDraft.Text = "IsDraft";
            this.IsDraft.UseVisualStyleBackColor = true;
            this.IsDraft.CheckedChanged += new System.EventHandler(this.IsDraft_CheckedChanged);
            // 
            // SenderName
            // 
            this.SenderName.AutoSize = true;
            this.SenderName.Location = new System.Drawing.Point(331, 321);
            this.SenderName.Name = "SenderName";
            this.SenderName.Size = new System.Drawing.Size(88, 17);
            this.SenderName.TabIndex = 13;
            this.SenderName.Text = "SenderName";
            this.SenderName.UseVisualStyleBackColor = true;
            this.SenderName.CheckedChanged += new System.EventHandler(this.SenderName_CheckedChanged);
            // 
            // MessageId
            // 
            this.MessageId.AutoSize = true;
            this.MessageId.Location = new System.Drawing.Point(211, 321);
            this.MessageId.Name = "MessageId";
            this.MessageId.Size = new System.Drawing.Size(78, 17);
            this.MessageId.TabIndex = 12;
            this.MessageId.Text = "MessageId";
            this.MessageId.UseVisualStyleBackColor = true;
            this.MessageId.CheckedChanged += new System.EventHandler(this.MessageId_CheckedChanged);
            // 
            // ConversationId
            // 
            this.ConversationId.AutoSize = true;
            this.ConversationId.Location = new System.Drawing.Point(108, 321);
            this.ConversationId.Name = "ConversationId";
            this.ConversationId.Size = new System.Drawing.Size(97, 17);
            this.ConversationId.TabIndex = 11;
            this.ConversationId.Text = "ConversationId";
            this.ConversationId.UseVisualStyleBackColor = true;
            this.ConversationId.CheckedChanged += new System.EventHandler(this.ConversationId_CheckedChanged);
            // 
            // AccountId
            // 
            this.AccountId.AutoSize = true;
            this.AccountId.Location = new System.Drawing.Point(0, 321);
            this.AccountId.Name = "AccountId";
            this.AccountId.Size = new System.Drawing.Size(75, 17);
            this.AccountId.TabIndex = 10;
            this.AccountId.Text = "AccountId";
            this.AccountId.UseVisualStyleBackColor = true;
            this.AccountId.CheckedChanged += new System.EventHandler(this.AccountId_CheckedChanged);
            // 
            // DataToReturn
            // 
            this.DataToReturn.AutoSize = true;
            this.DataToReturn.Location = new System.Drawing.Point(0, 293);
            this.DataToReturn.Name = "DataToReturn";
            this.DataToReturn.Size = new System.Drawing.Size(75, 13);
            this.DataToReturn.TabIndex = 9;
            this.DataToReturn.Text = "DataToReturn";
            // 
            // RecipientNames
            // 
            this.RecipientNames.AutoSize = true;
            this.RecipientNames.Location = new System.Drawing.Point(468, 321);
            this.RecipientNames.Name = "RecipientNames";
            this.RecipientNames.Size = new System.Drawing.Size(104, 17);
            this.RecipientNames.TabIndex = 14;
            this.RecipientNames.Text = "RecipientNames";
            this.RecipientNames.UseVisualStyleBackColor = true;
            this.RecipientNames.CheckedChanged += new System.EventHandler(this.RecipientNames_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "RunAnalysis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RecipientNames);
            this.Controls.Add(this.SenderName);
            this.Controls.Add(this.MessageId);
            this.Controls.Add(this.ConversationId);
            this.Controls.Add(this.AccountId);
            this.Controls.Add(this.DataToReturn);
            this.Controls.Add(this.IsDraft);
            this.Controls.Add(this.IsZivverMessage);
            this.Controls.Add(this.IsSent);
            this.Controls.Add(this.Recipients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.UserControl1 userControl11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Recipients;
        private System.Windows.Forms.CheckBox IsSent;
        private System.Windows.Forms.CheckBox IsZivverMessage;
        private System.Windows.Forms.CheckBox IsDraft;
        private System.Windows.Forms.CheckBox SenderName;
        private System.Windows.Forms.CheckBox MessageId;
        private System.Windows.Forms.CheckBox ConversationId;
        private System.Windows.Forms.CheckBox AccountId;
        private System.Windows.Forms.Label DataToReturn;
        private System.Windows.Forms.CheckBox RecipientNames;
        private System.Windows.Forms.Button button1;
    }
}

