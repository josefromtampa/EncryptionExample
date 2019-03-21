namespace EncryptionTest
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
      this.button1 = new System.Windows.Forms.Button();
      this.txtToEnc = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEnc = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDec = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(47, 295);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 40);
      this.button1.TabIndex = 0;
      this.button1.Text = "Encrypt ";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtToEnc
      // 
      this.txtToEnc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtToEnc.Location = new System.Drawing.Point(47, 258);
      this.txtToEnc.Name = "txtToEnc";
      this.txtToEnc.Size = new System.Drawing.Size(1125, 31);
      this.txtToEnc.TabIndex = 1;
      this.txtToEnc.Text = "This is  a test";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(42, 230);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(178, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "String To Encrypt";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 351);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(185, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "String To Decrypt:";
      // 
      // txtEnc
      // 
      this.txtEnc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtEnc.Location = new System.Drawing.Point(47, 379);
      this.txtEnc.Name = "txtEnc";
      this.txtEnc.Size = new System.Drawing.Size(1125, 31);
      this.txtEnc.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(51, 472);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(110, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Decrypted";
      // 
      // txtDec
      // 
      this.txtDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDec.Location = new System.Drawing.Point(47, 500);
      this.txtDec.Name = "txtDec";
      this.txtDec.Size = new System.Drawing.Size(1125, 31);
      this.txtDec.TabIndex = 6;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(47, 418);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(150, 51);
      this.button2.TabIndex = 5;
      this.button2.Text = "Decrypt";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.txtKey);
      this.groupBox1.Location = new System.Drawing.Point(33, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1149, 183);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(19, 96);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 25);
      this.label4.TabIndex = 8;
      this.label4.Text = "IV";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(24, 124);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(1058, 31);
      this.textBox1.TabIndex = 7;
      this.textBox1.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(19, 24);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 25);
      this.label5.TabIndex = 6;
      this.label5.Text = "Key";
      // 
      // txtKey
      // 
      this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKey.Location = new System.Drawing.Point(24, 52);
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(1058, 31);
      this.txtKey.TabIndex = 5;
      this.txtKey.Text = "DEAA954E-39F5-4F44-BD28-08F2987CF3B9";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.label6.Location = new System.Drawing.Point(203, 297);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(47, 33);
      this.label6.TabIndex = 9;
      this.label6.Text = "6";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.label7.Location = new System.Drawing.Point(203, 425);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 33);
      this.label7.TabIndex = 10;
      this.label7.Text = "6";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1253, 623);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtDec);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtEnc);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtToEnc);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtToEnc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEnc;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDec;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

