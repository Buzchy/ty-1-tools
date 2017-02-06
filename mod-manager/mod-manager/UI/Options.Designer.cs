﻿namespace TyModManager.UI
{
    partial class Options
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
            this.tbTestArgs = new System.Windows.Forms.TextBox();
            this.cbStartOnly = new System.Windows.Forms.CheckBox();
            this.gbStartOnly = new System.Windows.Forms.GroupBox();
            this.gbTestArgs = new System.Windows.Forms.GroupBox();
            this.btOkay = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbStartOnly.SuspendLayout();
            this.gbTestArgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTestArgs
            // 
            this.tbTestArgs.Location = new System.Drawing.Point(8, 18);
            this.tbTestArgs.Name = "tbTestArgs";
            this.tbTestArgs.Size = new System.Drawing.Size(252, 20);
            this.tbTestArgs.TabIndex = 1;
            // 
            // cbStartOnly
            // 
            this.cbStartOnly.AutoSize = true;
            this.cbStartOnly.Location = new System.Drawing.Point(8, 19);
            this.cbStartOnly.Name = "cbStartOnly";
            this.cbStartOnly.Size = new System.Drawing.Size(72, 17);
            this.cbStartOnly.TabIndex = 3;
            this.cbStartOnly.Text = "Start Only";
            this.cbStartOnly.UseVisualStyleBackColor = true;
            // 
            // gbStartOnly
            // 
            this.gbStartOnly.Controls.Add(this.cbStartOnly);
            this.gbStartOnly.Location = new System.Drawing.Point(12, 66);
            this.gbStartOnly.Name = "gbStartOnly";
            this.gbStartOnly.Size = new System.Drawing.Size(337, 44);
            this.gbStartOnly.TabIndex = 4;
            this.gbStartOnly.TabStop = false;
            this.gbStartOnly.Text = "Start Only on Test";
            // 
            // gbTestArgs
            // 
            this.gbTestArgs.Controls.Add(this.tbTestArgs);
            this.gbTestArgs.Location = new System.Drawing.Point(12, 12);
            this.gbTestArgs.Name = "gbTestArgs";
            this.gbTestArgs.Size = new System.Drawing.Size(337, 48);
            this.gbTestArgs.TabIndex = 5;
            this.gbTestArgs.TabStop = false;
            this.gbTestArgs.Text = "Test Arguments";
            // 
            // btOkay
            // 
            this.btOkay.Location = new System.Drawing.Point(182, 163);
            this.btOkay.Name = "btOkay";
            this.btOkay.Size = new System.Drawing.Size(75, 23);
            this.btOkay.TabIndex = 6;
            this.btOkay.Text = "OK";
            this.btOkay.UseVisualStyleBackColor = true;
            this.btOkay.Click += new System.EventHandler(this.BtOkay_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(274, 163);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(361, 198);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOkay);
            this.Controls.Add(this.gbTestArgs);
            this.Controls.Add(this.gbStartOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TY Mod Manager Options";
            this.TopMost = true;
            this.gbStartOnly.ResumeLayout(false);
            this.gbStartOnly.PerformLayout();
            this.gbTestArgs.ResumeLayout(false);
            this.gbTestArgs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTestArgs;
        private System.Windows.Forms.CheckBox cbStartOnly;
        private System.Windows.Forms.GroupBox gbStartOnly;
        private System.Windows.Forms.GroupBox gbTestArgs;
        private System.Windows.Forms.Button btOkay;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}