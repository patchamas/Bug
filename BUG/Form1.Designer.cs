namespace BUG
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
            this.txtNoBug = new System.Windows.Forms.TextBox();
            this.txtNoCondition = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.gridCondition = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoBug
            // 
            this.txtNoBug.Location = new System.Drawing.Point(205, 16);
            this.txtNoBug.Name = "txtNoBug";
            this.txtNoBug.Size = new System.Drawing.Size(100, 20);
            this.txtNoBug.TabIndex = 0;
            // 
            // txtNoCondition
            // 
            this.txtNoCondition.Location = new System.Drawing.Point(205, 39);
            this.txtNoCondition.Name = "txtNoCondition";
            this.txtNoCondition.Size = new System.Drawing.Size(100, 20);
            this.txtNoCondition.TabIndex = 1;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(205, 77);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(100, 20);
            this.txtCondition.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "#Bug --> จำนวนติดบัค (โหนด):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "#Path --> จำนวนเงื่อนไข (เส้น):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condition (T CCC RRR) :";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(205, 103);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(100, 23);
            this.btnAddCondition.TabIndex = 7;
            this.btnAddCondition.Text = "Add";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(6, 117);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 8;
            // 
            // gridCondition
            // 
            this.gridCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCondition.Location = new System.Drawing.Point(12, 141);
            this.gridCondition.Name = "gridCondition";
            this.gridCondition.Size = new System.Drawing.Size(293, 141);
            this.gridCondition.TabIndex = 9;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(205, 288);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 23);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PS --> T: Time, C: Condition, R: Result";
            // 
            // gridResult
            // 
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(311, 16);
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(573, 266);
            this.gridResult.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(784, 288);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gridCondition);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnAddCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtNoCondition);
            this.Controls.Add(this.txtNoBug);
            this.Name = "Form1";
            this.Text = "Bug Feature";
            ((System.ComponentModel.ISupportInitialize)(this.gridCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoBug;
        private System.Windows.Forms.TextBox txtNoCondition;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DataGridView gridCondition;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
    }
}

