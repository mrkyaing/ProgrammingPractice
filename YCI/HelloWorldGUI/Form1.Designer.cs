namespace HelloWorldGUI
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
            this.btnSayHi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToLoginUI = new System.Windows.Forms.Button();
            this.btnGotoSimpleCalcUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(64, 108);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(149, 23);
            this.btnSayHi.TabIndex = 0;
            this.btnSayHi.Text = "Say Hello World!";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is OOP?\r\nKey features of OOP?\r\nWhat is Class and Object?\r\nWhat is Inheritanc" +
    "e in OOP and which keyword use in C#?\r\nWhat is Polymorphism?";
            // 
            // btnGoToLoginUI
            // 
            this.btnGoToLoginUI.Location = new System.Drawing.Point(238, 108);
            this.btnGoToLoginUI.Name = "btnGoToLoginUI";
            this.btnGoToLoginUI.Size = new System.Drawing.Size(89, 27);
            this.btnGoToLoginUI.TabIndex = 2;
            this.btnGoToLoginUI.Text = "Go to Login UI";
            this.btnGoToLoginUI.UseVisualStyleBackColor = true;
            this.btnGoToLoginUI.Click += new System.EventHandler(this.btnGoToLoginUI_Click);
            // 
            // btnGotoSimpleCalcUI
            // 
            this.btnGotoSimpleCalcUI.Location = new System.Drawing.Point(342, 108);
            this.btnGotoSimpleCalcUI.Name = "btnGotoSimpleCalcUI";
            this.btnGotoSimpleCalcUI.Size = new System.Drawing.Size(157, 27);
            this.btnGotoSimpleCalcUI.TabIndex = 3;
            this.btnGotoSimpleCalcUI.Text = "Go To Simple Calc UI";
            this.btnGotoSimpleCalcUI.UseVisualStyleBackColor = true;
            this.btnGotoSimpleCalcUI.Click += new System.EventHandler(this.btnGotoSimpleCalcUI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 173);
            this.Controls.Add(this.btnGotoSimpleCalcUI);
            this.Controls.Add(this.btnGoToLoginUI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSayHi);
            this.Name = "Form1";
            this.Text = "Hello GUI ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToLoginUI;
        private System.Windows.Forms.Button btnGotoSimpleCalcUI;
    }
}

