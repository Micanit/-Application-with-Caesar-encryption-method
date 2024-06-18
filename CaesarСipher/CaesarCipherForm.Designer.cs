namespace CaesarСipher
{
    partial class CaesarCipherForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.originalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.originalLabel = new System.Windows.Forms.Label();
            this.originalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.encryptlabel = new System.Windows.Forms.Label();
            this.encryptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.substitutionLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.originalTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.originalTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(782, 453);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // originalTableLayoutPanel
            // 
            this.originalTableLayoutPanel.ColumnCount = 2;
            this.originalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.originalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.originalTableLayoutPanel.Controls.Add(this.substitutionLabel, 1, 0);
            this.originalTableLayoutPanel.Controls.Add(this.originalLabel, 0, 0);
            this.originalTableLayoutPanel.Controls.Add(this.originalRichTextBox, 0, 1);
            this.originalTableLayoutPanel.Controls.Add(this.stepTextBox, 1, 1);
            this.originalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.originalTableLayoutPanel.Name = "originalTableLayoutPanel";
            this.originalTableLayoutPanel.RowCount = 2;
            this.originalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.originalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.originalTableLayoutPanel.Size = new System.Drawing.Size(776, 220);
            this.originalTableLayoutPanel.TabIndex = 0;
            // 
            // originalLabel
            // 
            this.originalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(3, 7);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(199, 29);
            this.originalLabel.TabIndex = 0;
            this.originalLabel.Text = "Исходный текст:";
            // 
            // originalRichTextBox
            // 
            this.originalRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalRichTextBox.Location = new System.Drawing.Point(3, 47);
            this.originalRichTextBox.Name = "originalRichTextBox";
            this.originalRichTextBox.Size = new System.Drawing.Size(614, 170);
            this.originalRichTextBox.TabIndex = 1;
            this.originalRichTextBox.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(627, 106);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(141, 52);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.encryptlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.encryptRichTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.encryptButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 229);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 221);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // encryptlabel
            // 
            this.encryptlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encryptlabel.AutoSize = true;
            this.encryptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptlabel.Location = new System.Drawing.Point(3, 7);
            this.encryptlabel.Name = "encryptlabel";
            this.encryptlabel.Size = new System.Drawing.Size(495, 29);
            this.encryptlabel.TabIndex = 0;
            this.encryptlabel.Text = "Зашифрованный/расшифрованный текст:";
            // 
            // encryptRichTextBox
            // 
            this.encryptRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptRichTextBox.Location = new System.Drawing.Point(3, 47);
            this.encryptRichTextBox.Name = "encryptRichTextBox";
            this.encryptRichTextBox.Size = new System.Drawing.Size(614, 171);
            this.encryptRichTextBox.TabIndex = 1;
            this.encryptRichTextBox.Text = "";
            // 
            // substitutionLabel
            // 
            this.substitutionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.substitutionLabel.AutoSize = true;
            this.substitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substitutionLabel.Location = new System.Drawing.Point(625, 7);
            this.substitutionLabel.Name = "substitutionLabel";
            this.substitutionLabel.Size = new System.Drawing.Size(146, 29);
            this.substitutionLabel.TabIndex = 2;
            this.substitutionLabel.Text = "Шаг шифра";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepTextBox.Location = new System.Drawing.Point(648, 107);
            this.stepTextBox.MaxLength = 3;
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(100, 49);
            this.stepTextBox.TabIndex = 3;
            // 
            // CaesarCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaesarCipherForm";
            this.ShowIcon = false;
            this.Text = "Шифр цезаря ";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.originalTableLayoutPanel.ResumeLayout(false);
            this.originalTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel originalTableLayoutPanel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.RichTextBox originalRichTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label encryptlabel;
        private System.Windows.Forms.RichTextBox encryptRichTextBox;
        private System.Windows.Forms.Label substitutionLabel;
        private System.Windows.Forms.TextBox stepTextBox;
    }
}

